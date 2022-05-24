using ConsultancyFirm.BL.Abstract;
using ConsultancyFirm.EL;
using ConsultancyFirm.UI.Models;
using Microsoft.AspNetCore.Http;
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

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateMember(Member p,IFormFile file)
        {
            p.MemberImageURL = _memberService.UploadImage(file,"members");
            _memberService.Add(p);
            return RedirectToAction("MemberPage", new { memberusername = p.MemberUsername });
        }
        [HttpPost]
        public IActionResult RegisteredUser(string username,string password)
        {
          Member member=  _memberService.GetSingle(i => i.MemberUsername == username && i.MemberPasword == password);
            if (member!=null)
            {//member yazınc ageliyo ama username gönderince username i araya ayzıyo analamadım
                if (username=="admin" && password=="123")
                {
                    return RedirectToAction("Index", "Admin", new { password = 456 });
                }
                else
                {
                    return RedirectToAction("MemberPage", new { memberusername = member.MemberUsername });
                }
              
            }
            else
            {

                return RedirectToAction("Index");
            }
        }
        public IActionResult MemberPage(string memberusername)
        {
            Member member = _memberService.GetSingle(i => i.MemberUsername == memberusername );
            return View(member);
        }

        public IActionResult MemberService(string username)
        {
            var memberServiceModel = new MemberServiceModel()
            {
                Member = _memberService.GetSingle(i => i.MemberUsername == username)
            };
         
            return View(memberServiceModel);
        }

    }

}
