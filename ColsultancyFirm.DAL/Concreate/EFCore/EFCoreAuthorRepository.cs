using ColsultancyFirm.DAL.Abstract;
using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColsultancyFirm.DAL.Concreate.EFCore
{
    public class EFCoreAuthorRepository : EFCoreBaseRepository<Author, ConsultantFirmContext>, IAuthorRepository
    {
        public List<Author> GetProductWithPages(int page, int pageSize)
        {
            using (var context=new ConsultantFirmContext())
            {
               return context.Authors
                    .Skip((page - 1) * pageSize).Take(pageSize).ToList();
            }
        }
    }
}
