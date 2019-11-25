using System.Collections.Generic;

namespace Repository
{
    public interface IGenericRepository<T> where T : class
    {
        IEnumerable<T> GetList();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
    }
}
