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
    public class EFCoreBaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity:class 
    {
        protected readonly DbContext _context;
        public EFCoreBaseRepository(DbContext context)
        {
            _context = context;
        }

        public void Add(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Added;
            
        }

        public void Delete(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
        }

        public List<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
                return _context.Set<TEntity>().Where(filter).ToList();
        }

        public List<TEntity> GetAll()
        {
                return _context.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
                return _context.Set<TEntity>().Find(id);
        }

        public TEntity GetSingle(Expression<Func<TEntity, bool>> filter)
        {
                return _context.Set<TEntity>().FirstOrDefault(filter);
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
