using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.BL.Abstract
{
    public interface IHeadingService : IGenericService<Heading>
    {
    
        List<Heading> GetHomePageHeadings();
        List<Heading> GetHeadingByCategories(string category);
        List<Heading> GetHeadingWithAuthorWithCategory();
        void Add(Heading heading, int[] authorId);


    }
}
