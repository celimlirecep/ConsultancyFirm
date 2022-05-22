using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.EL
{
    public class Member
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string MemberSurname { get; set; }
        public string MemberFullName { get { return MemberName + " " + MemberSurname; } }
        public string MemberUsername { get; set; }
        public string MemberPasword { get; set; }
        [NotMapped]
        public string MemberPaswordRepeat { get; set; }
        public string MemberImageURL { get; set; }
        public string MemberMail { get; set; }

    }
}
