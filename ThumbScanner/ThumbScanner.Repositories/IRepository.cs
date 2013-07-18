using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThumbScanner.Repositories
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IEnumerable<T> Get();
        IEnumerable<T> Get(Func<T, bool> predicate);
        IQueryable<T> Query();
        T FirstOrDefault(Func<T, bool> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void SaveChanges();
    }
}
