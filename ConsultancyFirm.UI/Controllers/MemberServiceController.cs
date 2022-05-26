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
        public IActionResult Index(string username,int authorId,int CategoryId)
        {
            List<MemberService> memberServices = null;
            if (authorId!=0 && CategoryId==0)
            {
                memberServices= _memberservice_Service.Get(i => i.AuthorId == authorId);
            }
            else if (CategoryId != 0 && authorId == 0)
            {
                memberServices = _memberservice_Service.Get(i => i.CategoryId == CategoryId);
            }
            else if (CategoryId != 0 && authorId != 0)
            {
                memberServices = _memberservice_Service.Get(i => i.CategoryId == CategoryId && i.AuthorId==authorId);
            }
            else
            {
                 memberServices = _memberservice_Service.GetAll();
            }
            
            Member member = _memberService.GetSingle(i => i.MemberUsername == username);
            MemberServiceModel memberServiceModel = new MemberServiceModel()
            {
                Member = member,
                Categories = _categoryService.GetAll(),
                Authors = _authorService.GetAll(),
                MemberServices = memberServices
            };

            return View(memberServiceModel);
        }

        public IActionResult MemberAppointment(string username)
        {
            Member member = _memberService.GetSingle(i => i.MemberUsername == username);
            MemberServiceModel memberServiceModel = new MemberServiceModel()
            {
                Member=member,
                MemberServices = _memberservice_Service.Get(i => i.MemberId == member.MemberId),
                Authors = _authorService.GetAll(),

            };
     
            return View(memberServiceModel);
        }


        [HttpPost]
        public IActionResult MemberAppointment(MemberServiceModel memberServiceModel,List<int> memberserviceIds)
        {
            MemberService memberService = _memberservice_Service.GetById(memberserviceIds[0]);
            memberService.MemberId = memberServiceModel.MemberService.MemberId;
            memberService.CategoryId = memberService.CategoryId;
            memberService.AuthorId = memberService.AuthorId;
            memberService.AppointmentTime = memberService.AppointmentTime;
            memberService.MemberServiceId = memberService.MemberServiceId;
            _memberservice_Service.Update(memberService);
            memberServiceModel.MemberService = memberService;
            memberServiceModel.Authors = _authorService.GetAll();
            memberServiceModel.MemberServices = _memberservice_Service.Get(i => i.MemberId == memberServiceModel.MemberService.MemberId);
           memberServiceModel.Member = _memberService.GetSingle(i => i.MemberUsername == memberServiceModel.Member.MemberUsername);
            return View(memberServiceModel);
        }
    }
    
}
