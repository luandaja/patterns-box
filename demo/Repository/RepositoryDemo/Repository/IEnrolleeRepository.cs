using Models;

namespace Repository
{
    public interface IEnrolleeRepository : IGenericRepository<Enrollees>
    {
        bool IsActive(int enrolleeId);
    }
}
