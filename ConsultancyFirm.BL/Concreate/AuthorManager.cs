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
            _authorRepository.Add(entity);
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

        public List<Author> GetAuthorsWithPages(int page, int pageSize)
        {
            return _authorRepository.GetAuthorsWithPages(page, pageSize);
        }

        public Author GetSingle(Expression<Func<Author, bool>> filter)
        {
            return _authorRepository.GetSingle(filter);
        }

        public void Update(Author entity)
        {
            _authorRepository.Update(entity);
        }
    }
}
