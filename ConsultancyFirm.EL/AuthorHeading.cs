using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.EL
{
     public class AuthorHeading
    {
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int HeadingId { get; set; }
        public Heading Heading { get; set; }

    }
}
