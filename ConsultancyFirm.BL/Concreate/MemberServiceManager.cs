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
    public class MemberServiceManager : IMemberService_Service
    {
        IMemberServiceRepository _memberServiceRepository;

        public MemberServiceManager(IMemberServiceRepository memberServiceRepository)
        {
            _memberServiceRepository = memberServiceRepository;
        }

        public void Add(MemberService entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(MemberService entity)
        {
            _memberServiceRepository.Delete(entity);
        }

        public List<MemberService> Get(Expression<Func<MemberService, bool>> filter)
        {
            return _memberServiceRepository.Get(filter);
        }

        public List<MemberService> GetAll()
        {
            return _memberServiceRepository.GetAll();
        }

        public MemberService GetById(int id)
        {
            return _memberServiceRepository.GetById(id);
        }

        //Henüz tarihe göre filtreleme yapılmadı
        public List<MemberService> GetMemberServicesBySelectedAppointmentInfo(int authorId, int categoryId, DateTime dateTime)
        {
          return  _memberServiceRepository.GetMemberServicesBySelectedAppointmentInfo(authorId, categoryId, dateTime);
        }

        public MemberService GetSingle(Expression<Func<MemberService, bool>> filter)
        {
            return _memberServiceRepository.GetSingle(filter);
        }

        public List<MemberService> GetThisDaysMemberServices()
        {
            return _memberServiceRepository.GetThisDaysMemberServices();
        }

        

        public void Update(MemberService entity)
        {
            _memberServiceRepository.Update(entity);
        }
    }
}
