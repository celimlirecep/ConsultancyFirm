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

        public async Task<IActionResult> Index(string username, MemberServiceModel model=null)
        {
            List<MemberService> memberServices = null;
            if (model.Author != null && model.Category != null)
            {
                if (model.Author.AuthorId != 0 && model.Category.CategoryId == 0)
                {

                    memberServices = _memberservice_Service.Get(i => i.AuthorId == model.Author.AuthorId && string.IsNullOrEmpty(i.UserId));

                }
                else if (model.Category.CategoryId != 0 && model.Author.AuthorId == 0)
                {

                    memberServices = _memberservice_Service.Get(i => i.CategoryId == model.Category.CategoryId && string.IsNullOrEmpty(i.UserId));

                }
                else
                {
                    memberServices = _memberservice_Service.Get(i => i.CategoryId == model.Category.CategoryId && i.AuthorId == model.Author.AuthorId && string.IsNullOrEmpty(i.UserId));
                }

            }
            else
            {
                memberServices = _memberservice_Service.Get(i => string.IsNullOrEmpty(i.UserId) == true);
            }



            User user = await _userManager.FindByNameAsync(username);

            MemberServiceModel memberServiceModel = new MemberServiceModel()
            {
                User = user,
                Users = _userManager.Users.ToList(),
                Categories = _categoryService.GetAll(),
                Authors = _authorService.GetAll(),
                MemberServices = memberServices
            };
            ViewBag.Category = new SelectList(_categoryService.GetAll(), "CategoryId", "CategoryName");
            ViewBag.Author =  new SelectList(_authorService.GetAll(), "AuthorId", "AuthorFullName");
            return View(memberServiceModel);
        }

        public async Task<IActionResult> MemberAppointment()
        {
            User user = await _userManager.GetUserAsync(User);
         
            MemberServiceModel memberServiceModel = new MemberServiceModel()
            {
                User=user,
               MemberServices = _memberservice_Service.Get(i => i.UserId == user.Id),
                Authors = _authorService.GetAll(),

            };
     
            return View(memberServiceModel);
        }
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
        public IActionResult MemberAppointment(string userId,int memberServiceId,string userName)
        {
            if (string.IsNullOrEmpty(userId)||memberServiceId<1)
            {
                return View();
            }
           MemberService memberService=  _memberservice_Service.GetById(memberServiceId);
            memberService.UserId = userId;
            memberService.CategoryId = memberService.CategoryId;
            memberService.AuthorId = memberService.AuthorId;
            memberService.AppointmentTime = memberService.AppointmentTime;
            _memberservice_Service.Update(memberService);



            return Redirect($"/mypage/appointment/{userName}");
        }
    }
    
}
