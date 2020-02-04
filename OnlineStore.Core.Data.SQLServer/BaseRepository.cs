using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace OnlineStore.Core.Data.SQLServer
{
    public class BaseRepository<T> where T : class
    {
        protected OnlineStoreDbContext _OnlineStoreDbContext;
        protected DbSet<T> dbset;
        public BaseRepository(OnlineStoreDbContext DbContext)
        {
            _OnlineStoreDbContext = DbContext; 
            this.dbset = _OnlineStoreDbContext.Set<T>();
        }
        public virtual DbSet<T> GetDbSet()
        {
            return this.dbset;
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbset.AsNoTracking().ToArray();
        }

        public virtual IEnumerable<T> GetAll(Expression<Func<T, bool>> where)
        {
            if (where != null)
                return dbset.AsNoTracking().Where(where).ToList();
            else
                return dbset.AsNoTracking().ToArray();
        }

        public virtual IEnumerable<T> GetAll(int maxRecordCount)
        {
            if (maxRecordCount == -1)
                return dbset.ToList();
            else
                return dbset.Take(maxRecordCount);
        }

        public virtual T GetById(int id)
        {
            return dbset.Find(id);
        }

        public virtual T GetById(Guid id)
        {
            return dbset.Find(id);
        }

        public virtual T Add(T item)
        {
            _OnlineStoreDbContext.Set<T>().Add(item);
            _OnlineStoreDbContext.SaveChanges();
            return item;
        }

        public virtual int Update(T item)
        {
            this.dbset.Attach(item);
            _OnlineStoreDbContext.Entry(item).State = EntityState.Modified;
            return _OnlineStoreDbContext.SaveChanges();
        }

        public virtual int Update(T item, params Expression<Func<T, object>>[] properties)
        {
            this.dbset.Attach(item);
            EntityEntry<T> entry = _OnlineStoreDbContext.Entry(item);
            foreach (var property in properties)
            {
                entry.Property(property).IsModified = true;
            }
            return _OnlineStoreDbContext.SaveChanges();
        }

        public virtual void Delete(T item)
        {
            dbset.Remove(item);
            _OnlineStoreDbContext.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            dbset.Remove(dbset.Find(id));
            _OnlineStoreDbContext.SaveChanges();
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
            _OnlineStoreDbContext.SaveChanges();
        }
    }
}
