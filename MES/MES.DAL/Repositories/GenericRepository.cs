namespace MES.DAL.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Text;
    using MES.DAL.Interfaces;
    using Microsoft.EntityFrameworkCore;

    public class GenericRepository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        private readonly DbContext context;
        private readonly DbSet<TEntity> dbSet;

        public GenericRepository(DbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> Get()
        {
            return this.dbSet.AsNoTracking().ToList();
        }

        public IEnumerable<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return this.dbSet.AsNoTracking().Where(predicate).ToList();
        }

        public TEntity FindById(int id)
        {
            return this.dbSet.Find(id);
        }

        public void Create(TEntity item)
        {
            this.dbSet.Add(item);
            this.context.SaveChanges();
        }

        public void Update(TEntity item)
        {
            this.context.Entry(item).State = EntityState.Modified;
            this.context.SaveChanges();
        }

        public void Remove(TEntity item)
        {
            this.dbSet.Remove(item);
            this.context.SaveChanges();
        }

        public IEnumerable<TEntity> GetWithInclude(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            return this.Include(includeProperties).ToList();
        }

        public IEnumerable<TEntity> GetWithInclude(
            Func<TEntity, bool> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var query = this.Include(includeProperties);
            return query.Where(predicate).ToList();
        }

        private IQueryable<TEntity> Include(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = this.dbSet.AsNoTracking();
            return includeProperties
                .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }
    }
}
