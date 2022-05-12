using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.EL
{
    public class Heading
    {
        public int HeadingId { get; set; }
        public string HeadingName { get; set; }
        public string HeadingContent { get; set; }
        public string HeadingUrl { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsHome { get; set; }
        //Yazılan makaleler onaydan geçtikten sonra yayınlansın istiyorum
        public bool IsApproved { get; set; }
        public List<Author> Authors { get; set; }
        public Category Category { get; set; }


    }
}
