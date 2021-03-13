using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using V2.DAL.InfraStructure;

namespace V2.InfraStructure
{
    public abstract class BaseRepository<T> where T : BaseEntity
    {
        private DbContext _dbContext;
        public DbContext DbContext { get; set; }
        public IDbSet<T> DbSet { get; set; }

        protected BaseRepository()
        {
            DbContext = _dbContext;
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

        public virtual T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return DbSet.AsNoTracking().ToList();
        }

        public virtual void Delete(T entity)
        {
            DbSet.Remove(entity);
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