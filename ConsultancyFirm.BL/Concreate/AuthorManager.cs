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
        private IAuthorRepository _authorRepository;
        public AuthorManager(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
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
            return _authorRepository.GetAll();
        }

        public Author GetById(int id)
        {
            return _authorRepository.GetSingle(x=>x.AuthorId==id);
        }

        public List<Author> GetProductWithPages(int page, int pageSize)
        {
            return _authorRepository.GetProductWithPages(page, pageSize);
        }

        

        public void Update(Author entity)
        {
            throw new NotImplementedException();
        }
    }
}
