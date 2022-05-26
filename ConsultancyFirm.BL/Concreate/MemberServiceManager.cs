using ColsultancyFirm.DAL.Abstract;
using ConsultancyFirm.BL.Abstract;
using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.BL.Concreate
{
    public class MemberServiceManager : JobManager, IMemberService_Service
    {
        IMemberServiceRepository _memberServiceRepository;

        public MemberServiceManager(IMemberServiceRepository memberServiceRepository)
        {
            _memberServiceRepository = memberServiceRepository;
        }

        public List<MemberService> Get(Expression<Func<MemberService, bool>> filter)
        {
            return _memberServiceRepository.Get(filter);
        }

        public List<MemberService> GetAll()
        {
            return _memberServiceRepository.GetAll();
        }
    }
}
