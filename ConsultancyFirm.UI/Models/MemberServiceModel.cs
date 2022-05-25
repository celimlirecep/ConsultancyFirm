﻿using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Models
{
    public class MemberServiceModel
    {
        public Member Member { get; set; }
        public List<Category> Categories { get; set; }
        public List<Author> Authors { get; set; }
        public MemberService MemberService { get; set; }
        public List<MemberService> MemberServices { get; set; }
        public string QueryUrl { get; set; }



    }
}