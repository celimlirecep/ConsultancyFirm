using ConsultancyFirm.EL;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Models
{
    public class AddHeadingModel
    {
        public int AuthorId { get; set; }
        public IFormFile File { get; set; }
        public Heading Heading { get; set; }
    }
}
