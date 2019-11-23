---
description: This is summary from the talk session.
---

# Repository

## ✅Goals

* Make the data appear as if it is just living inside an in memory collection so at business or higher layers it’s unaware of the data access complexity.
* Increase developers's productivity by enabling them to focus on bussines logic.

## 🏛Architecture

{% hint style="info" %}
\[If needed add notes here\]
{% endhint %}

\[Insert an image to describe the expected architecture\]

## 🌎Real case example

\[Describe your case\]

\[Add an image to support your text\]

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
public BookViewModel GetBookById() 
{
}

//Use Instead
public Book GetBookById() 
{
}
```

Where Book class is a Context model.

### Methods that return IQueryable<T> type

* Unless it's a private method, none of the methods on a repository should return a IQueryable<T> type, always call ToList() or ToArray().
Take this example:
```csharp
var customersByBook = context.Books
			.Include(o => o.Invoices)
				.ThenInclude(o => o.Customers)
			.Where(o => o.BookId == 14);
```
We are directly retrieving information from our DbContext, if our repository method returns IQueryable, someone else may compose a query on top of it, like so:
```csharp
var customersByBook = repository.GetBooks()
			.Include(o => o.Invoices)
				.ThenInclude(o => o.Customers)
			.Where(o => o.BookId == 14);
```
The only difference between these two examples is the first line were the method GetBooks is being called, so we are not solving the problem of hidding the complexity from that layer. Instead what we should have is something like this:
```csharp
var customersByBook = repository.GetCustomersByBookId(14);
```
Were GetCustomersByBook returns a list rather than a IQueryable.

### Thinking that a repository should manage transactions

* The repository is NOT responsible for managing database transactions. This concern is best managed using Unit Of Work pattern.

### Not properly testing the repository

* Every method of our repositories should be covered by one or more integration tests, which should use the same kind of DB that we use in production environment.

## 🎭Effects

### Advantages

* Business logic can be unit tested without data access logic.
* The database access code can be reused.
* It gives a substitution point for the unit tests.

### Drawbacks

#### Over time it may accumulate very similar Find methods

* Over long periods of times, a repository may accumulate dozens and dozens of very similar Find methods. This can be solved using the Query Object Pattern or the Builder Pattern or, for bigger repositories, CQRS Pattern.

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
This contains a piece of business logic that describes what it means for an order to be active. What we need here is the Specification Pattern, which will look similar to:

```csharp
public IEnumerable<Order> FindActiveOrders() {
  return base.FindBySpec(new ActiveOrders())
          .ToArray();
}
```

## References

* https://programmingwithmosh.com/net/common-mistakes-with-the-repository-pattern/
* https://marcin-chwedczuk.github.io/repository-pattern-my-way
* Pluralsight Design Patterns Libraty

## Demo 

{% hint style="info" %}
The demo is hosted on the next github repository
{% endhint %}

\[Link here\]

