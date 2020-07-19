using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HappyFacesAPI.Repository
{
    public interface IHappyFacesRepository<TEntity>  where TEntity : class
    {
       
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity values);
        void Remove(TEntity values);
        void AddRange(IEnumerable<TEntity> entities);
        void RemoveRange(IEnumerable<TEntity> entities);

    }
}
