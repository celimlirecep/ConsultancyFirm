using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.BL.Abstract
{
    public interface IAuthorService
    {
        Author GetById(int id);
        List<Author> GetAll();
        void Update(Author entity);
        void Delete(Author entity);
        void Add(Author entity);
        List<Author> Get(Expression<Func<Author, bool>> filter);
    }
}
