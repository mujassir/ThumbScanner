using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ThumbScanner.Entities;
using System.Data.Objects;

namespace ThumbScanner.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private ThumbScannerDBEntities db;
        public GenericRepository()
        {
            db = SessionFactory.GetContext();
        }
        private ObjectSet<T> _objectSet;
        public ObjectSet<T> ObjectSet
        {
            get
            {
                if (_objectContext == null)
                    _objectContext = db.CreateObjectSet<T>();
                return _objectContext;
            }
        }
        public IEnumerable<T> Get()
        {
            return ObjectSet.ToList();
        }

        public IEnumerable<T> Get(Func<T, bool> predicate)
        {
            return ObjectSet.Where(predicate).ToList()
        }

        public IQueryable<T> Query()
        {
            return ObjectSet;
        }

        public IQueryable<T> Query(Func<T, bool> predicate)
        {
           return ObjectSet.Where(predicate)
        }

        public T FirstOrDefault(Func<T, bool> predicate)
        {
            return ObjectSet.FirstOrDefault(predicate);
        }

        public void Add(T entity)
        {
            ObjectSet.AddObject(entity);
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            ObjectSet.DeleteObject(entity);
        }

        public void SaveChanges()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            //db.Dispose();
        }
    }
}
