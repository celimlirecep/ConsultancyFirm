using ColsultancyFirm.DAL.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ColsultancyFirm.DAL.Concreate.EFCore
{
    public class EFCoreBaseRepository<TEntity, TContext> : IBaseRepository<TEntity> where TEntity:class where TContext:DbContext,new()
    {


        public void Add(TEntity entity)
        {
            using (var context=new ConsultantFirmContext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            using (var context=new ConsultantFirmContext())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        public TEntity GetById(int id)
        {

            throw new NotImplementedException();
        }

        public TEntity GetSingle(Expression<Func<TEntity, bool>> filter)
        {
            using (var context=new ConsultantFirmContext())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
