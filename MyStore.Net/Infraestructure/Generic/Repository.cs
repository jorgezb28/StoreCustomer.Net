using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Domain.Generic;

namespace Infraestructure.Generic
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
      
        public void Add(TEntity entity)
        {
            using (var context = new MyStoreDbContext())
            {
                context.Entry(entity).State= EntityState.Added;
                context.SaveChanges();
            }
        }

        public IList<TEntity> GetAll()
        {
            List<TEntity> result;
            using (var context = new MyStoreDbContext())
            {
                result = context.Set<TEntity>().ToList();
            }
            return result;
        }

        public TEntity GetSingle(System.Linq.Expressions.Expression<Func<TEntity, bool>> filter)
        {
            TEntity result;
            using (var context = new MyStoreDbContext())
            {
                result = context.Set<TEntity>().FirstOrDefault(filter);
            }
            return result;
        }
    }
}
