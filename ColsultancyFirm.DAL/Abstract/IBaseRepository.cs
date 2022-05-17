using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ColsultancyFirm.DAL.Abstract
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        List<TEntity> GetAll();
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void Add(TEntity entity);
        List<TEntity> Get(Expression<Func<TEntity, bool>> filter);
         TEntity GetSingle(Expression<Func<TEntity, bool>> filter);


    }
}
