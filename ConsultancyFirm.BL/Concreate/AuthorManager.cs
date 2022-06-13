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
        private readonly IUnitOfWork _unitOfWork;
        public AuthorManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Author entity)
        {
            _unitOfWork.Authors.Add(entity);
            _unitOfWork.save();
        }

        public void Delete(Author entity)
        {
            throw new NotImplementedException();
        }

        public List<Author> Get(Expression<Func<Author, bool>> filter)
        {
           return _unitOfWork.Authors.Get(filter);
        }

        public List<Author> GetAll()
        {
            return _unitOfWork.Authors.GetAll();
        }

        public Author GetById(int id)
        {
            return _unitOfWork.Authors.GetSingle(x=>x.AuthorId==id);
        }

        public List<Author> GetAuthorsWithPages(int page, int pageSize)
        {
            return _unitOfWork.Authors.GetAuthorsWithPages(page, pageSize);
        }

        public Author GetSingle(Expression<Func<Author, bool>> filter)
        {
            return _unitOfWork.Authors.GetSingle(filter);
        }

        public void Update(Author entity)
        {
            _unitOfWork.Authors.Update(entity);
            _unitOfWork.save();
        }
    }
}
