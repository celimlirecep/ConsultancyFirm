using ConsultancyFirm.BL.Abstract;
using ConsultancyFirm.Core;
using ConsultancyFirm.EL;
using ConsultancyFirm.UI.Identity;
using ConsultancyFirm.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Controllers
{
    public class MemberServiceController : Controller
    {
  
        private ICategoryService _categoryService;
        private IAuthorService _authorService;
        private IMemberService_Service _memberservice_Service;
        private UserManager<User> _userManager;

        public MemberServiceController( ICategoryService categoryService, IAuthorService authorService, IMemberService_Service memberservice_Service, UserManager<User> userManager)
        {
           
            _categoryService = categoryService;
            _authorService = authorService;
            _memberservice_Service = memberservice_Service;
            _userManager = userManager;
        }

        //Randevu alım sayfası
        public IActionResult Index()
        {

           
            ViewBag.Category = new SelectList(_categoryService.GetAll(), "CategoryId", "CategoryName");
            ViewBag.Author =  new SelectList(_authorService.GetAll(), "AuthorId", "AuthorFullName");
            return View(_memberservice_Service.GetThisDaysMemberServices());
        }
        [HttpPost]
        public IActionResult Index(MemberServiceFilterModel model)
        {
            List<MemberService> memberServices = _memberservice_Service.GetMemberServicesBySelectedAppointmentInfo(model.authorId, model.categoryId, model.appointmentDate);
            ViewBag.Category = new SelectList(_categoryService.GetAll(), "CategoryId", "CategoryName");
            ViewBag.Author = new SelectList(_authorService.GetAll(), "AuthorId", "AuthorFullName");

            return View(memberServices);
        }

        public async Task<IActionResult> MemberAppointment()
        {
            User user = await _userManager.GetUserAsync(User);
         
            MemberServiceModel memberServiceModel = new MemberServiceModel()
            {
              
               MemberServices = _memberservice_Service.Get(i => i.UserId == user.Id),
                Authors = _authorService.GetAll(),

            };
     
            return View(memberServiceModel);
        }

        //Alınan hizmetler Sayfası
        public IActionResult DeleteAppointment(int MemberServiceId)
        {
            var memberService= _memberservice_Service.GetSingle(i => i.MemberServiceId == MemberServiceId);
            if (memberService==null)
            {
               
                TempData["Message"] = JobManager.CreateMessage("Bilgi", "Silmek istediğiniz kayda ilişkin bir kayıt bulunamamıştır", "warning");
                return RedirectToAction("MemberAppointment");
            }
            memberService.UserId = string.Empty;
            _memberservice_Service.Update(memberService);
           

            return RedirectToAction("MemberAppointment");
        }
        [HttpPost]
        public IActionResult MemberAppointment(string userId,int memberServiceId)
        {
            if (string.IsNullOrEmpty(userId)||memberServiceId<1)
            {
                return View();
            }
           MemberService memberService=  _memberservice_Service.GetById(memberServiceId);
            memberService.UserId = userId;
            _memberservice_Service.Update(memberService);



            return Redirect($"/mypage/appointment");
        }
    }
    
}
