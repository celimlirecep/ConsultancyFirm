using ConsultancyFirm.EL;
using ConsultancyFirm.UI.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Models
{
    public class MemberServiceModel
    {
        public User User { get; set; }
        public List<Category> Categories { get; set; }
        public List<Author> Authors { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }

        public MemberService MemberService { get; set; }
        public List<MemberService> MemberServices { get; set; }
        public string QueryUrl { get; set; }



    }
}
