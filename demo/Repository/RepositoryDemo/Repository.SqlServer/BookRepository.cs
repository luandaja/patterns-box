using Models;
using System.Linq;

namespace Repository.SqlServer
{
    public class BookRepository : GenericRepository<Books>, IBookRepository
    {
        public BookRepository(SqlDbContext context) : base(context)
        {
        }

        public bool IsActive(int bookId)
        {
            return _context.Set<Books>().FirstOrDefault(x => x.Id == bookId && x.IsActive) != null;
        }
    }
}
