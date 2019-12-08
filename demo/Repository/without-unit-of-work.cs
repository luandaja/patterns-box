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
    _context.Add(entity);
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