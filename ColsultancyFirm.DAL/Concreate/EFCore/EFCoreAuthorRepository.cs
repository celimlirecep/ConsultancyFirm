using ColsultancyFirm.DAL.Abstract;
using ConsultancyFirm.EL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColsultancyFirm.DAL.Concreate.EFCore
{
    public class EFCoreAuthorRepository : EFCoreBaseRepository<Author>, IAuthorRepository
    {
        public EFCoreAuthorRepository(ConsultantFirmContext context):base(context)
        {

        }
        private ConsultantFirmContext ConsultantFirmContext
        {
            get { return _context as ConsultantFirmContext; }
        }

        public List<Author> GetAuthorsWithPages(int page, int pageSize)
        {
            
               return ConsultantFirmContext.Authors
                .Include(i=>i.AuthorHeadings)
                    .Skip((page - 1) * pageSize).Take(pageSize).ToList();
            
        }
    }
}
