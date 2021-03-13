using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using V2.DAL.DB_Context;

namespace V2.InfraStructure
{
    public abstract class BaseRepository<T>  where T : BaseEntity
    {
        public DbContext DbContext { get; set; }
        public IDbSet<T> DbSet { get; set; }

        protected BaseRepository()
        {
            DbContext = new ECommerceDbContext();
            DbSet = DbContext.Set<T>();
        }
        protected BaseRepository(DbContext dbContext)
        {
            DbContext = dbContext;
            DbSet = DbContext.Set<T>();
        }


        public virtual void Create(T entity)
        {
            DbSet.Add(entity);
        }

        public virtual void Update(T entity)
        {
            DbSet.Attach(entity);
            DbContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = DbSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                DbSet.Remove(obj);
        }

        public virtual T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return DbSet.AsNoTracking().ToList();
        }

        public virtual IEnumerable<T> GetAll(Expression<Func<T, bool>> where, params Expression<Func<T, object>>[] properties)
        {
            if (where == null)
                throw new ArgumentNullException(nameof(where));
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));

            var query = DbSet as IQueryable<T>;

            query = properties.Aggregate(query, (current, property) => current.Include(property));

            return query.AsNoTracking().Where(where).ToList();
        }
        public virtual IEnumerable<T> GetAll(Expression<Func<T, bool>> where, bool asNoTrackning, params Expression<Func<T, object>>[] properties)
        {
            if (where == null)
                throw new ArgumentNullException(nameof(where));
            if (properties == null)
                throw new ArgumentNullException(nameof(properties));

            var query = DbSet as IQueryable<T>;
            if (asNoTrackning)
            {
                query = query.AsNoTracking();
            }
            query = properties.Aggregate(query, (current, property) => current.Include(property));

            return query.AsNoTracking().Where(where).ToList();
        }


        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return DbSet.AsNoTracking().Where(where).ToList();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return DbSet.AsNoTracking().Where(where).FirstOrDefault<T>();
        }

        public int Count()
        {
            return DbSet.Count();
        }

        public void SaveChanges()
        {
            DbContext.SaveChanges();
        }
    }
}
