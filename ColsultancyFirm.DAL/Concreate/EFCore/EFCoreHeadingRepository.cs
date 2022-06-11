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
    public class EFCoreHeadingRepository : EFCoreBaseRepository<Heading, ConsultantFirmContext>, IHeadingRepository
    {
        


        public List<Heading> GetHomePageHeadings()
        {
            using (var context=new ConsultantFirmContext())
            {
             return   context.Headings
                    .Where(i => i.IsHome && i.IsApproved)
                    .Include(c => c.Category)
                    .Include(x=>x.AuthorHeadings)
                    .ThenInclude(x=>x.Author)
                    .ToList();
            }
        }
        public List<Heading> GetHeadingByCategories(string category)
        {
            using (var context = new ConsultantFirmContext())
            {
                var headings = context.Headings
                    .Where(i => i.IsApproved)
                    .AsQueryable();
                if (!string.IsNullOrEmpty(category))
                {
                    headings = headings
                    .Include(i => i.Category)
                    .Where(i => i.Category.CategoryUrl == category)
                    .Include(i => i.AuthorHeadings)
                    .ThenInclude(i => i.Author);
                    
                }
                    


                return headings.ToList();
            }
        }

        public List<Heading> GetHeadingWithAuthorWithCategory()
        {
            using (var context =new ConsultantFirmContext())
            {
                return context.Headings
                    .Include(i => i.AuthorHeadings)
                    .ThenInclude(i => i.Author)
                    .Include(i=>i.Category)
                    .ToList();
            }
        }

        public void Add(Heading heading, int[] authorIds)
        {
            using (var context=new ConsultantFirmContext())
            {
                context.Headings.Add(heading);
                context.SaveChanges();
                heading.AuthorHeadings = authorIds
                   .Select(authorId => new AuthorHeading
                   {
                       AuthorId = authorId,
                       HeadingId = heading.HeadingId
                   }).ToList();
                context.SaveChanges();

            }
        }
    }
}
