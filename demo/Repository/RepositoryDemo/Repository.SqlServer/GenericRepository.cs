using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Repository.SqlServer
{
    public abstract class GenericRepository<T> : IDisposable, IGenericRepository<T> where T : class
    {
        protected readonly EnterpriseDbContext _context;
        protected GenericRepository(EnterpriseDbContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Remove(entity);
            _context.SaveChanges();
        }
        public T GetById(int id)
        {
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            return _context.Find<T>(id);
        }

        public IEnumerable<T> GetList()
        {
            return _context.Set<T>().AsNoTracking();
        }

        public void Update(T entity)
        {
            _context.Update(entity);
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context?.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
