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
        public string AuthorName { get; set; }
        public string AuthorSurname { get; set; }
        [NotMapped]
        public string AuthorFullName { get {return  AuthorName + " " + AuthorSurname; } }
        public string AuthorImages { get; set; }
        public string AuthorMail { get; set; }
        public string AuthorPhone { get; set; }
        public Decimal AuthorHourlyWage { get; set; }
        public string AuthorUrl { get; set; }
        public bool IsDeleted { get; set; }
       


        public List<AuthorHeading> AuthorHeadings { get; set; }
        public List<AuthorCategory> AuthorCategories { get; set; }


    }
}
