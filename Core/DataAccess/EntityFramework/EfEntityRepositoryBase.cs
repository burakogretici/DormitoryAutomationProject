using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.Abstract;
using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext> : IEntityRepository<TEntity> 
        where TEntity:class,IEntity,new()
        where TContext : DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext tContext=new TContext())
            {
                var addedEntity = tContext.Entry(entity);
                addedEntity.State = EntityState.Added;
                tContext.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext tContext=new TContext())
            {
                var deletedEntity = tContext.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                tContext.SaveChanges();
            }
            
        }

        public void Update(TEntity entity)
        {
            using (TContext tContext = new TContext())
            {
                var updatedEntity = tContext.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                tContext.SaveChanges();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext tContext = new TContext())
            {
                return filter == null
                    ? tContext.Set<TEntity>().ToList()
                    : tContext.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext tContext = new TContext())
            {
                return tContext.Set<TEntity>().SingleOrDefault(filter);
            }
        }
    }
}
