using ColsultancyFirm.DAL.Abstract;
using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColsultancyFirm.DAL.Concreate.EFCore
{
    public class EFCoreHeadingRepository : EFCoreBaseRepository<Heading, ConsultantFirmContext>, IHeadingRepository
    {
        public List<Heading> GetHomePageHeadings()
        {
            using (var context=new ConsultantFirmContext())
            {
             return   context.Headings
                    .Where(i => i.IsHome && i.IsApproved)
                    .ToList();
            }
        }
    }
}
