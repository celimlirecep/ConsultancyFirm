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
    public class HeadingManager : IHeadingService
    {
        private readonly IUnitOfWork _unitOfWork;
        public HeadingManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public void Add(Heading entity)
        {
            _unitOfWork.Headings.Add(entity);
            _unitOfWork.save();
        }

        public void Add(Heading heading, int[] authorId)
        {
            _unitOfWork.Headings.Add(heading, authorId);
            _unitOfWork.save();
        }

        public void Delete(Heading entity)
        {
            throw new NotImplementedException();
        }

        public List<Heading> Get(Expression<Func<Heading, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Heading> GetAll()
        {
           return _unitOfWork.Headings.GetAll();
        }

        

        public Heading GetById(int id)
        {
            return _unitOfWork.Headings.GetById(id);
        }

     

        public List<Heading> GetHeadingByCategories(string category)
        {
          return  _unitOfWork.Headings.GetHeadingByCategories(category);
        }

        public List<Heading> GetHeadingWithAuthorWithCategory()
        {
            return _unitOfWork.Headings.GetHeadingWithAuthorWithCategory();
        }

        public List<Heading> GetHomePageHeadings()
        {
            return _unitOfWork.Headings.GetHomePageHeadings();
        }

        public Heading GetSingle(Expression<Func<Heading, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Heading entity)
        {
            _unitOfWork.Headings.Update(entity);
            _unitOfWork.save();
        }
    }
}
