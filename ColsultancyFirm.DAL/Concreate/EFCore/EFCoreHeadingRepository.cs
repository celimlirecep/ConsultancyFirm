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
    public class EFCoreHeadingRepository : EFCoreBaseRepository<Heading>, IHeadingRepository
    {
        public EFCoreHeadingRepository(ConsultantFirmContext context) : base(context)
        {

        }
        private ConsultantFirmContext ConsultantFirmContext
        {
            get { return _context as ConsultantFirmContext; }
        }


        public List<Heading> GetHomePageHeadings()
        {
            
             return ConsultantFirmContext.Headings
                    .Where(i => i.IsHome && i.IsApproved)
                    .Include(c => c.Category)
                    .Include(x=>x.AuthorHeadings)
                    .ThenInclude(x=>x.Author)
                    .ToList();
            
        }
        public List<Heading> GetHeadingByCategories(string category)
        {
            
                var headings = ConsultantFirmContext.Headings
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

        public List<Heading> GetHeadingWithAuthorWithCategory()
        {
            
                return ConsultantFirmContext.Headings
                    .Include(i => i.AuthorHeadings)
                    .ThenInclude(i => i.Author)
                    .Include(i=>i.Category)
                    .ToList();
            
        }

        public void Add(Heading heading, int[] authorIds)
        {

            ConsultantFirmContext.Headings.Add(heading);
            ConsultantFirmContext.SaveChanges();
                heading.AuthorHeadings = authorIds
                   .Select(authorId => new AuthorHeading
                   {
                       AuthorId = authorId,
                       HeadingId = heading.HeadingId
                   }).ToList();
           

            
        }
    }
}
