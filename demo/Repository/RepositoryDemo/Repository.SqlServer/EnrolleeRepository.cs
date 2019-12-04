using Models;
using System.Linq;

namespace Repository.SqlServer
{
    public class EnrolleeRepository : GenericRepository<Enrollees>, IEnrolleeRepository
    {
        public EnrolleeRepository(EnterpriseDbContext context) : base(context)
        {
        }

        public bool IsActive(int enrolleeId)
        {
            return _context.Set<Enrollees>().FirstOrDefault(x => x.Id == enrolleeId && x.IsActive) != null;
        }
    }
}
