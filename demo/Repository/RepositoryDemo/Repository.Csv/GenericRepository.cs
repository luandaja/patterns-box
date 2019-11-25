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

        public IEnumerable<T> GetList()
        {
            using (TextReader fileReader = File.OpenText(_filePath))
            {
                var csv = new CsvReader(fileReader);
                return csv.GetRecords<T>().ToList();
            }
        }

        #region Not Implemented

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
