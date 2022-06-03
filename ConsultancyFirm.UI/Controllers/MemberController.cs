using ConsultancyFirm.BL.Abstract;
using ConsultancyFirm.EL;
using ConsultancyFirm.UI.Identity;
using ConsultancyFirm.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Controllers
{
    public class MemberController : Controller
    {
        private IMemberService _memberService;
        private UserManager<User> _userManager;

        public MemberController(IMemberService memberService, UserManager<User> userManager)
        {
            _memberService = memberService;
            _userManager = userManager;
        }

        public async Task<IActionResult> MemberPage(string username)
        {
            //      CookieOptions cookie = new CookieOptions();
            //cookie.Expires = DateTime.Now.AddHours(3);

            //Response.Cookies.Append("username", username, cookie);
            ViewBag.Username = username;
            var user = await _userManager.FindByNameAsync(username);
            return View(user);
        }

     

    }

}
