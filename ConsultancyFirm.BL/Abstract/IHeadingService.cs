using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.BL.Abstract
{
    public interface IHeadingService
    {
        Heading GetById(int id);
        List<Heading> GetAll();
        void Update(Heading entity);
        void Delete(Heading entity);
        void Add(Heading entity);
        List<Heading> Get(Expression<Func<Heading, bool>> filter);
        List<Heading> GetHomePageHeadings();
    }
}
