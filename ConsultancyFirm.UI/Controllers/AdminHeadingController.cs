using ConsultancyFirm.BL.Abstract;
using ConsultancyFirm.EL;
using ConsultancyFirm.UI.Identity;
using ConsultancyFirm.UI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Controllers
{
    public class AdminHeadingController : Controller
    {
        private IHeadingService _headingService;
        private UserManager<User> _userManager;

        public AdminHeadingController(IHeadingService headingService, UserManager<User> userManager)
        {
            _headingService = headingService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            List<Heading> headingList = _headingService.GetHeadingWithAuthorWithCategory();
            List<HeadingCardModel> model =new List<HeadingCardModel>();
            foreach (var head in headingList)
            {
                List<string> userIdList = head.AuthorHeadings.Select(i => i.Author.UserId).ToList();
                HeadingCardModel cardModel = new HeadingCardModel();
                List<string> AuthorNameList = new List<string>();
                List<string> AuthorımageList = new List<string>();
                //yazara ait bilgiler
                foreach (var userId in userIdList)
                {
                    User user = await _userManager.FindByIdAsync(userId);
                    string fullname = $"{user.FirstName} {user.LastName}";
                    AuthorNameList.Add(fullname);
                    AuthorımageList.Add(user.MemberImage);

                }
                cardModel.AuthorsFullName = AuthorNameList;
                cardModel.AuthorImage = AuthorımageList;
                cardModel.CategoryName = head.Category.CategoryName;
                cardModel.HeadingModel = head;
                model.Add(cardModel);
            }
     
            return View(model);
        }

       
    }
}
