using ColsultancyFirm.DAL.Abstract;
using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColsultancyFirm.DAL.Concreate.EFCore
{
   public class EFCoreMemberServiceRepository : EFCoreBaseRepository<MemberService, ConsultantFirmContext>, IMemberServiceRepository
    {
    }
}
