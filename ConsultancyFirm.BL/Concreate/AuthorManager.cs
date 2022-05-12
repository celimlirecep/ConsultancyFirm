using ColsultancyFirm.DAL.Abstract;
using ConsultancyFirm.BL.Abstract;
using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.BL.Concreate
{
    public class AuthorManager : IAuthorService
    {
        public void Add(Author entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Author entity)
        {
            throw new NotImplementedException();
        }

        public List<Author> Get(Expression<Func<Author, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Author> GetAll()
        {
            throw new NotImplementedException();
        }

        public Author GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
