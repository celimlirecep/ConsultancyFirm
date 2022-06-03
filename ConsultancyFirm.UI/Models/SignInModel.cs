using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Models
{
    public class SignInModel
    {
        [Required]
        public string LoginUserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string LoginPassword { get; set; }

    }
}
