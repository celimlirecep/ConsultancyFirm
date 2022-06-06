using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.BL.Abstract
{
    public interface IAuthorService:IGenericService<Author>
    {
       
        List<Author> GetAuthorsWithPages(int page, int pageSize);
     
    }
}
