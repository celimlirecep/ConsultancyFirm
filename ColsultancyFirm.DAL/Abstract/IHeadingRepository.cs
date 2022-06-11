using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColsultancyFirm.DAL.Abstract
{
    public interface IHeadingRepository:IBaseRepository<Heading>
    {
        List<Heading> GetHomePageHeadings();

         List<Heading> GetHeadingWithAuthorWithCategory();
        List<Heading> GetHeadingByCategories(string categoryUrl);
         void Add(Heading heading, int[] authorId);
    }
}
