using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThumbScanner.Entities;

namespace ThumbScanner.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private ThumbScannerDBEntities db;

        public IEnumerable<T> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Get(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Query()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Query(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public T FirstOrDefault(Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
