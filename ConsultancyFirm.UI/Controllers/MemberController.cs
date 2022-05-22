using ConsultancyFirm.BL.Abstract;
using ConsultancyFirm.EL;
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
            return RedirectToAction("MemberPage",p.MemberUsername);
        }
        [HttpPost]
        public IActionResult RegisteredUser(string username,string password)
        {
          Member member=  _memberService.GetSingle(i => i.MemberUsername == username && i.MemberPasword == password);
            if (member!=null)
            {//member yazınc ageliyo ama username gönderince username i araya ayzıyo analamadım
                return RedirectToAction("MemberPage", member.MemberUsername);
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

    }

}
