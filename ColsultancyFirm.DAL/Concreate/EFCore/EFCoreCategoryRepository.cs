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
    public class EFCoreCategoryRepository : EFCoreBaseRepository<Category>, ICategoryRepository
    {
        public EFCoreCategoryRepository(ConsultantFirmContext context) : base(context)
        {

        }
        private ConsultantFirmContext ConsultantFirmContext
        {
            get { return _context as ConsultantFirmContext; }
        }

    }
}
