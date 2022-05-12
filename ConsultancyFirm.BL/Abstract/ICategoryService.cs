using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.BL.Abstract
{
    public interface ICategoryService
    {
        Category GetById(int id);
        List<Category> GetAll();
        void Update(Category entity);
        void Delete(Category entity);
        void Add(Category entity);
        List<Category> Get(Expression<Func<Category, bool>> filter);
      

    }
}
