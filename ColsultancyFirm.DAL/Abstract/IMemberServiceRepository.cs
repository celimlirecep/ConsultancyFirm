using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColsultancyFirm.DAL.Abstract
{
    public interface IMemberServiceRepository : IBaseRepository<MemberService>
    {
        public List<MemberService> GetMemberServicesBySelectedAppointmentInfo(int authorId, int categoryId, DateTime dateTime);
        List<MemberService> GetThisDaysMemberServices();
        List<MemberService> GetMemberServicesWithAuthorsAndCategoriesByUser(string userId);
    }
}
