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
        [StringLength(20,MinimumLength =5)]
        public string LoginUserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 5)]
        public string LoginPassword { get; set; }

    }
}
