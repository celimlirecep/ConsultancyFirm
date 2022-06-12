using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Models
{
    public class MemberServiceFilterModel
    {
        public int authorId { get; set; }
        public int categoryId { get; set; }
        public DateTime appointmentDate { get; set; }
    }
}
