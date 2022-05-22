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
    public class MemberManager:JobManager,IMemberService
    {
        IMemberRepository _memberRepository;

        public MemberManager(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public void Add(Member entity)
        {
            _memberRepository.Add(entity);
        }

        public void Delete(Member entity)
        {
            throw new NotImplementedException();
        }

        public List<Member> GetAll()
        {
            throw new NotImplementedException();
        }

        public Member GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Member GetSingle(Expression<Func<Member, bool>> filter)
        {
           return _memberRepository.GetSingle(filter);
        }

        public void Update(Member entity)
        {
            throw new NotImplementedException();
        }
    }
}
