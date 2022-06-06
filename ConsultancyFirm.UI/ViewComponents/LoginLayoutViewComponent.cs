using ConsultancyFirm.UI.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.ViewComponents
{
    public class LoginLayoutViewComponent : ViewComponent
    {
        private UserManager<User> _userManager;

        public LoginLayoutViewComponent(UserManager<User> userManager)
        {
            this._userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
           User user =await _userManager.GetUserAsync((System.Security.Claims.ClaimsPrincipal)User);
            return View(user);
        }
    }
}
