using ConsultancyFirm.UI.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Models
{
    public class RoleAssignModel
    {
        public IEnumerable<IdentityRole> Rolls { get; set; }
        public IEnumerable<User> Users { get; set; }
        public List<UserRolesModel> UserRolesList { get; set; }
        public string RoleName { get; set; }
        public string UserId { get; set; }
        public bool IsAdded { get; set; }


    }
}
