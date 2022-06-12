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
       
       
        public List<Category> Categories { get; set; }
        public List<Author> Authors { get; set; }
 
 
        public List<MemberService> MemberServices { get; set; }
       
        



    }
}
