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
    public class EFCoreMemberServiceRepository : EFCoreBaseRepository<MemberService>, IMemberServiceRepository
    {
        public EFCoreMemberServiceRepository(ConsultantFirmContext context) : base(context)
        {

        }
        private ConsultantFirmContext ConsultantFirmContext
        {
            get { return _context as ConsultantFirmContext; }
        }
        public List<MemberService> GetMemberServicesBySelectedAppointmentInfo(int authorId, int categoryId, DateTime dateTime)
        {
                var memberServicesList = ConsultantFirmContext.MemberServices
                    .AsQueryable();
                //sadece yazar filtrelendiğinde
                if (authorId != 0 && categoryId == 0)
                {
                    memberServicesList = memberServicesList
                        .Where(i => i.AuthorId == authorId && string.IsNullOrEmpty(i.UserId))
                        .AsQueryable();
                }
                //sadece category filtrelendiğinde
                else if (categoryId != 0 && authorId == 0)
                {
                    memberServicesList = memberServicesList
                        .Where(i => i.CategoryId == categoryId && string.IsNullOrEmpty(i.UserId))
                        .AsQueryable();
                }
                //hem yazar hem categoriye filtre uygulandığında
                else 
                {
                    memberServicesList = memberServicesList
                        .Where(i => i.CategoryId == categoryId && i.AuthorId == authorId && string.IsNullOrEmpty(i.UserId))
                        .AsQueryable();
                }
            memberServicesList = memberServicesList
                  .Include(i => i.Category)
                .Include(i => i.Author);

                return memberServicesList.ToList();
        }

        public List<MemberService> GetMemberServicesWithAuthorsAndCategoriesByUser(string userId)
        {
            return ConsultantFirmContext.MemberServices
                 .Where(i => i.UserId == userId)
                 .Include(i => i.Author)
                 .Include(i => i.Category)
                 .ToList();
        }

        //çalışmalar tamamlandıktan sonra sadece bugünün randevuları gözükücek
        public List<MemberService> GetThisDaysMemberServices()
        {
            var memberServiceList= ConsultantFirmContext.MemberServices
                .Include(i => i.Category)
                .Include(i => i.Author)
                .Where(i => string.IsNullOrEmpty(i.UserId))
                .AsQueryable();
            int count = memberServiceList.Count();
            if (count>6)
            {
               memberServiceList=memberServiceList
                    .Take(6);
            }
            return memberServiceList.ToList();
                    
            
        }
    }
}
