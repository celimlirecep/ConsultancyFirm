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
    public class MemberServiceController : Controller
    {
        private IMemberService _memberService;
        private ICategoryService _categoryService;
        private IAuthorService _authorService;
        private IMemberService_Service _memberservice_Service;

        public MemberServiceController(IMemberService memberService,ICategoryService categoryService,IAuthorService authorService, IMemberService_Service memberservice_Service)
        {
            _memberService = memberService;
            _categoryService = categoryService;
            _authorService = authorService;
            _memberservice_Service = memberservice_Service;
        }
        public IActionResult Index(string username,int authorId)
        {
            
            Member member = _memberService.GetSingle(i => i.MemberUsername == username);
            MemberServiceModel memberServiceModel = new MemberServiceModel()
            {
                Member = member,
                Categories = _categoryService.GetAll(),
                Authors = _authorService.GetAll(),
                MemberServices = _memberservice_Service.GetAll()
            };

            return View(memberServiceModel);
        }
    }
    
}
