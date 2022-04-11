using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()  

    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity); 
                addedEntity.State = EntityState.Added;  
                context.SaveChanges(); 
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity); 
                updatedEntity.State = EntityState.Modified;  
                context.SaveChanges(); 
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity); 
                deletedEntity.State = EntityState.Deleted;  
                context.SaveChanges(); 
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)  // bu tek data getırcek
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);//Tek bir sonucun döneceği kesin ise ve de sonuc donmeyebilir ise kullanılır.
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                // arka planda select * from product çalıştırıyor                
                return filter == null //filtre null mu 
                       ? context.Set<TEntity>().ToList() //evet ise bu çalışır
                       : context.Set<TEntity>().Where(filter).ToList(); //değilse filtre ver
            }
        }

    }
}
