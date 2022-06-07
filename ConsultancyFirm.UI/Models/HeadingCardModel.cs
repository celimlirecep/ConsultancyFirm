using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Models
{
    public class HeadingCardModel
    {
        public Heading HeadingModel { get; set; }
        public List<Author> AuthorsModel { get; set; }
        public string CategoryName { get; set; }
        public List<string> AuthorImage { get; set; }
        public List<string> AuthorsFullName { get; set; }
      



    }
}
