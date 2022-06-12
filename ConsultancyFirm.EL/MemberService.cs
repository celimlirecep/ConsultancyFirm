using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.EL
{
    public class MemberService
    {
        public int MemberServiceId { get; set; }
        public string UserId { get; set; }
        public int MyProperty { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public DateTime  AppointmentTime { get; set; }


    }
}
