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
        public List<Category> Categories { get; set; }
        public string AuthorFullName { get; set; }
        public string AuthorImage { get; set; }


    }
}
