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
        private readonly IUnitOfWork _unitOfWork;
        public MemberServiceManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(MemberService entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(MemberService entity)
        {
            _unitOfWork.MemberServices.Delete(entity);
            _unitOfWork.save();
        }

        public List<MemberService> Get(Expression<Func<MemberService, bool>> filter)
        {
            return _unitOfWork.MemberServices.Get(filter);
        }

        public List<MemberService> GetAll()
        {
            return _unitOfWork.MemberServices.GetAll();
        }

        public MemberService GetById(int id)
        {
            return _unitOfWork.MemberServices.GetById(id);
        }

        //Henüz tarihe göre filtreleme yapılmadı
        public List<MemberService> GetMemberServicesBySelectedAppointmentInfo(int authorId, int categoryId, DateTime dateTime)
        {
          return _unitOfWork.MemberServices.GetMemberServicesBySelectedAppointmentInfo(authorId, categoryId, dateTime);
        }

        public List<MemberService> GetMemberServicesWithAuthorsAndCategoriesByUser(string userId)
        {
          return  _unitOfWork.MemberServices.GetMemberServicesWithAuthorsAndCategoriesByUser(userId);
        }

        public MemberService GetSingle(Expression<Func<MemberService, bool>> filter)
        {
            return _unitOfWork.MemberServices.GetSingle(filter);
        }

        public List<MemberService> GetThisDaysMemberServices()
        {
            return _unitOfWork.MemberServices.GetThisDaysMemberServices();
        }

        

        public void Update(MemberService entity)
        {
            _unitOfWork.MemberServices.Update(entity);
            _unitOfWork.save();
        }
    }
}
