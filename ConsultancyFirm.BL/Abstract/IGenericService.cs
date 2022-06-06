using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.BL.Abstract
{
   public interface IGenericService<T> where T:class
    {


        void Add(T entity);
        void Delete(T entity);
        public List<T> Get(Expression<Func<T, bool>> filter);
        public List<T> GetAll();
        public T GetById(int id);
       
        public T GetSingle(Expression<Func<T, bool>> filter);
        public void Update(T entity);
       
    }
}
