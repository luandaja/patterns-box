using Models;

namespace Repository
{
    public interface IBookRepository : IGenericRepository<Books>
    {
        bool IsActive(int bookId);
    }
}
