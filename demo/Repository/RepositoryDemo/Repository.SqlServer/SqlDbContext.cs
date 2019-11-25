using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository.SqlServer
{
    public class SqlDbContext : DbContext
    {
        public SqlDbContext()
        {

        }

        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base (options)
        {

        }

        public virtual DbSet<Books> Books { get; set; }
        public virtual DbSet<Authors> Authors { get; set; }
    }
}
