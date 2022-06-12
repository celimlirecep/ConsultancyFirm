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
    public class EFCoreMemberServiceRepository : EFCoreBaseRepository<MemberService, ConsultantFirmContext>, IMemberServiceRepository
    {
        public List<MemberService> GetMemberServicesBySelectedAppointmentInfo(int authorId, int categoryId, DateTime dateTime)
        {
            using (var context = new ConsultantFirmContext())
            {

                var memberServicesList =  context.MemberServices
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

        }

        //çalışmalar tamamlandıktan sonra sadece bugünün randevuları gözükücek
        public List<MemberService> GetThisDaysMemberServices()
        {
            using (var context=new ConsultantFirmContext())
            {
                return context.MemberServices
                    .Include(i => i.Category)
                    .Include(i => i.Author)
                    .Take(6).ToList();
            }
        }
    }
}
