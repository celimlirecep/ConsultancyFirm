using ConsultancyFirm.EL;
using ConsultancyFirm.UI.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Models
{
    public class MemberServiceModel
    {
        public User User { get; set; }
        public List<User> Users { get; set; }
        public List<Category> Categories { get; set; }
        public List<Author> Authors { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }
        public MemberService MemberService { get; set; }
        public List<MemberService> MemberServices { get; set; }
        [BindProperty, DataType("month")]
        public DateTime Month { get; set; }
        public string QueryUrl { get; set; }



    }
}
