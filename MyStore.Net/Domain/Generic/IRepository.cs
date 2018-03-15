using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Domain.Generic
{
    public interface IRepository<TEntity> where TEntity:class
    {
        TEntity GetSingle(Expression<Func<TEntity, bool>> filter);
        IList<TEntity> GetAll();
        void Add(TEntity entity);

    }
}
