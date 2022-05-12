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
        private IHeadingRepository _headingrepository;
        public HeadingManager(IHeadingRepository headingRepository)
        {
            _headingrepository = headingRepository;
        }
        public void Add(Heading entity)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public Heading GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Heading> GetHomePageHeadings()
        {
            return _headingrepository.GetHomePageHeadings();
        }

        public void Update(Heading entity)
        {
            throw new NotImplementedException();
        }
    }
}
