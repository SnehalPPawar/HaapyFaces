using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Linq.Expressions;

namespace HappyFacesAPI.Repository
{
    public class HappyFacesRepository<TEntity> : IHappyFacesRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext context;
        private DbSet<TEntity> Table;
        public HappyFacesRepository(DbContext context)
        {
            this.context = context;
            Table = context.Set<TEntity>();
        }
        public void Add(TEntity values)
        {
            context.Set<TEntity>().Add(values);
            Table.Add(values);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            context.Set<TEntity>().AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity,bool>>predicate)
        {
            return context.Set<TEntity>().Where(predicate);
        }

        public void Remove(TEntity values)
        {
            context.Set<TEntity>().Remove(values);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            context.Set<TEntity>().RemoveRange(entities);
        }
    }
}