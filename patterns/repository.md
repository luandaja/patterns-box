---
description: This is summary from the talk session.
---

# Repository

## ✅Goals

* Make the data appear as if it is just living inside an in memory collection so at business or higher layers it’s unaware of the data access complexity.
* Increase developers's productivity by enabling them to focus on bussines logic.

## 🏛Architecture

![](https://raw.githubusercontent.com/luandaja/patterns-box/master/patterns/.gitbook/assets/repository_architecture.png)

## 🌎Real case example

Picture the next scenario:

1. As part of the process of buying a new home, the seller requests several documents, some of which are only delivered by a couple of goberment institutions.
2. Unfortunately the process of requesting these documents to these institutions is very time comsuming and complex. 
3. Soon we realized that it's better to hand over these responsability to someone else, an accountant or legal consultant, which we hire.
4. This person will easly and happily finish requesting every needed document from the goberment institutions.
5. Finally he/she will hand us over said documents so we can deliver them to the seller and continue the buying process.

![](https://raw.githubusercontent.com/luandaja/patterns-box/master/patterns/.gitbook/assets/repository_real_world_case.png)

## ☢What problems does it solve?

* Duplication of data access code
* Complex migration from one data source to another
* Typically data access code is very repetitive and its concern with low level infrastructure details like opening sql connections and managing sql parameters and transactions.

## ⏲When to use it?

* When our application needs to access data from multiple data sources making it prone to duplication of code.
* When our business layer needs focus on those algorithms that make the business work.
* When we are developing an MVP which we know will change from data source eventually.

## ⚠When not to use it?

* When we have entities for which doesn't make sense to allow full CRUD operations (Can be easily solved by splitting the interface into three: One for reading, one for updating and one for deleting).

## ‼Common mistakes when implementing

### Not having one repository per domain class

* If we have an application called "National Library", there shouldn't be a repository called:
```csharp
public class NationalLibraryRepository() 
{
}
```
  Instead, we should have a separate repository per domain class, like BookRepository, AuthorRepository, ShelfRepository.

### Returning view models or DTOs

* A repository method shouldn't return view models or DTOs. Mapping a domian object into a view model/DTO should be the responsibility of a higher level layer like a Service or a Controller.

```csharp

//Do not use
public BookViewModel GetBookById(int id) 
{
  //Code that maps from context model to view model
}

//Use Instead
public Book GetBookById(int id) 
{
  //Code that only retrieves data
}
```

Where Book class is a Context model.

### Methods that return IQueryable<T> type

* Unless it's a private method, none of the methods on a repository should return a IQueryable<T> type, always call ToList() or ToArray().
Take this example:
```csharp
var invoicesByBook = context.Books
			.Include(o => o.Invoices)
			.Where(o => o.BookId == 14)
      .Select(o => o.Invoices);
```
We are directly retrieving information from our DbContext, if our repository method returns IQueryable, someone else may compose a query on top of it, like so:
```csharp
var invoicesByBook = repository.GetBooks()
			.Include(o => o.Invoices)
			.Where(o => o.BookId == 14)
      .Select(o => o.Invoices);
```
The only difference between these two examples is the first line were the method GetBooks is being called, so we are not solving the problem of hidding the complexity from that layer. Instead what we should have is something like this:
```csharp
var invoicesByBook = repository.GetInvoicesByBookId(14);
```
Were GetInvoicesByBookId returns a list rather than a IQueryable.

### Thinking a repository should manage transactions

* The repository is NOT responsible for managing database transactions. This concern is best managed using Unit Of Work pattern.

Without UnitOfWork Pattern:

```csharp
public class AuthorRepository : IAuthorRepository
{
  public void Update(Author entity){
    _context.Update(entity);
    _context.SaveChanges();
  }
}
public class BookRepository : IBookRepository
{
  public void Add(Book entity){
    _context.Update(entity);
    _context.SaveChanges();
  }
}

public class LibraryService
{
  private readonly IAuthorRepository _authorRepository;
  private readonly IBookRepository _bookRepository;

  //Constructor where injection is done
  //...

  public void ExampleMethod(){
    //...some logic
    _authorRepository.Update(author);
    //author gets updated
    _bookRepository.Add(newBook);
    //new book is saved
  }
}
```

With UnitOfWork Pattern:

```csharp
public class AuthorRepository : IAuthorRepository
{
  public void Update(Author entity){
    _context.Update(entity);
}
public class BookRepository : IBookRepository
{
  public void Add(Book entity){
    _context.Update(entity);
  }
}
public class UnitOfWork : IUnitOfWork
{
  private ContextDb _context;

  //Constructor where injection is done
  //and repositories are initialized

  public AuthorRepository Authors { get; private set;}
  public BookRepository Books { get; private set; }

  public void Commit(){
    _context.SaveChanges();
  }

}

public class LibraryService
{
  private readonly IUnitOfWork _unitOfWork

  //Constructor where injection is done
  //...

  public void ExampleMethod(){

    //...some logic

    _unitOfWork.Authors.Update(author);
    //author is not updated yet
    _unitOfWork.Books.Add(newBook);
    //new book is not saved yet
    _unitOfWork.Commit();
    //Both operations are saved together

  }
}
```

### Not properly testing the repository

* Every method of our repositories should be covered by one or more integration tests, which should use the same kind of DB we use in production environment.

## 🎭Effects

### Advantages

* Business logic can be unit tested without data access logic.
* The database access code can be reused.
* It gives a substitution point for the unit tests.

### Drawbacks

#### Over time it may accumulate very similar Find methods

* Over long periods of times, a repository may accumulate dozens and dozens of very similar Find methods. This can be solved using the Query Object Pattern or the Builder Pattern or, for bigger repositories, CQRS Pattern.

```csharp
public interface IBookRepository{
  Book GetBookById(int id);
  Book GetBookByAuthorId(int authorId);
  Book GetBookByPublisherId(int publisherId);
  Book GetBookByLastCustomerId(int customerId);
  Book GetBookByIdForUpdate(int id);
}
```

#### Wrong placing of business logic

* Unwanted migration of the business logic into query definitions. For example:

```csharp
public IEnumerable<Order> FindActiveOrders() {
  return base.FindAll()
          .Where(order => order.State != OrderState.Closed 
                       && order.State != OrderState.Canceled)
          .ToArray();
}
```
This contains a piece of business logic which describes what it means for an order to be active. What we need here is the Specification Pattern, which will look similar to:

```csharp
public IEnumerable<Order> FindActiveOrders() {
  return base.FindBySpec(new ActiveOrders())
          .ToArray();
}
```

## References

* https://programmingwithmosh.com/net/common-mistakes-with-the-repository-pattern/
* https://marcin-chwedczuk.github.io/repository-pattern-my-way
* Pluralsight Design Patterns Library

## Demo 

{% hint style="info" %}
The demo is hosted on the next github repository
{% endhint %}

\[Link here\]

