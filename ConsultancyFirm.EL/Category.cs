using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.EL
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDesription { get; set; }
        public string CategoryUrl { get; set; }
        public bool IsDeleted { get; set; }
        public List<Heading> Headings { get; set; }

    }
}
