﻿using ColsultancyFirm.DAL.Abstract;
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
        public List<Heading> GetHeadingByAuthors(string authorNameUrl)
        {
            using (var context = new ConsultantFirmContext())
            {
                var headings= context.Headings
                     .Where(i => i.IsApproved)
                     .AsQueryable();
                     if (!string.IsNullOrEmpty(authorNameUrl))
                {
                    headings = headings
                    .Include(i => i.AuthorHeadings)
                    .ThenInclude(i => i.Author)
                 .Where(i => i.AuthorHeadings.Any(i => i.Author.AuthorUrl == authorNameUrl));
                     
                }
                return headings.ToList();
                     
            }
        }


        public List<Heading> GetHomePageHeadings()
        {
            using (var context=new ConsultantFirmContext())
            {
             return   context.Headings
                    .Where(i => i.IsHome && i.IsApproved)
                    .ToList();
            }
        }
        public List<Heading> GetHeadingByCategories(string category)
        {
            using (var context = new ConsultantFirmContext())
            {
                return context.Headings
                    .Where(i => i.IsApproved)
                    .Include(i => i.Category)
                    .Where(i => i.Category.CategoryUrl == category)
                    .ToList();
            }
        }

      
    }
}
