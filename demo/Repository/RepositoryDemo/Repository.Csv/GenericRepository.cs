using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repository.Csv
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly string _filePath;

        public GenericRepository(string filePath)
        {
            _filePath = filePath;
        }

        public T GetById(int id)
        {
            using (TextReader fileReader = File.OpenText(_filePath))
            {
                var csv = new CsvReader(fileReader);
                return csv.GetRecords<T>().AsQueryable();
            }
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetList()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
