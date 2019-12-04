public class AuthorRepository : IAuthorRepository
{
  public void Update(Author entity){
    _context.Update(entity);
}
public class BookRepository : IBookRepository
{
  public void Add(Book entity){
    _context.Add(entity);
  }
}
public class UnitOfWork : IUnitOfWork
{
  private ContextDb _context;

  //Constructor where injection is done
  //and repositories are initialized

  public AuthorRepository Authors { get; private set; }
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