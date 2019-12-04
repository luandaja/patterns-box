using Microsoft.EntityFrameworkCore;
using Models;

namespace Repository.SqlServer
{
    public class EnterpriseDbContext : DbContext
    {
        public EnterpriseDbContext()
        {

        }

        public EnterpriseDbContext(DbContextOptions<EnterpriseDbContext> options) : base (options)
        {

        }

        public virtual DbSet<Enrollees> Enrollees { get; set; }
    }
}
