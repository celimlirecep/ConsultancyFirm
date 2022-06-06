using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.EL
{
    public  class Author
    {
        public int AuthorId { get; set; }
        public string UserId { get; set; }
        public Decimal AuthorHourlyWage { get; set; }
        public string AuthorAbout { get; set; }
        public bool IsDeleted { get; set; }
        public List<AuthorHeading> AuthorHeadings { get; set; }
        public List<AuthorCategory> AuthorCategories { get; set; }


    }
}
