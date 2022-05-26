using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.BL.Abstract
{
    public interface IMemberService_Service : IJobService
    {
        List<MemberService> GetAll();
        List<MemberService> Get(Expression<Func<MemberService, bool>> filter);
        MemberService GetById(int id);
        void Update(MemberService entity);
    }
}
