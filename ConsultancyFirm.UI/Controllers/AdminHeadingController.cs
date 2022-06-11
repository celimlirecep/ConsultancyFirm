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
    public class AdminHeadingController : Controller
    {
        private IHeadingService _headingService;
        private UserManager<User> _userManager;
        private IAuthorService _authorService;
        private ICategoryService _categoryService;

        public AdminHeadingController(IHeadingService headingService, UserManager<User> userManager, IAuthorService authorService, ICategoryService categoryService)
        {
            _headingService = headingService;
            _userManager = userManager;
            _authorService = authorService;
            _categoryService = categoryService;
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

        public IActionResult AddHeading()
        {
            
            ViewBag.Author = new SelectList(_authorService.GetAll(), "AuthorId", "AuthorFullName");
            ViewBag.Authors = _authorService.GetAll();
            ViewBag.Category = new SelectList(_categoryService.GetAll(), "CategoryId", "CategoryName");


            return View();
        }
        [HttpPost]
        public IActionResult AddHeading(AddHeadingModel model)
        {
            if (!ModelState.IsValid)
            {
                
                ModelState.AddModelError("", "Lütfen giriş bilgilerini tam olarak doldurup tekrar deneyiniz");
                return RedirectToAction("AddHeading");
            }
            string userId =  _userManager.GetUserId(User);
            Author author = _authorService.GetSingle(i => i.UserId == userId);
            //Category category = _categoryService.GetById(model.Heading.CategoryId);
            Heading heading = new Heading();

            heading.CategoryId = model.Heading.CategoryId;
            heading.HeadingContent = model.Heading.HeadingContent;
            heading.HeadingName = model.Heading.HeadingName;
            heading.HeadingImageUrl = JobManager.UploadImage(model.File, "HeadingImage");
            heading.HeadingPublishTime = DateTime.Now;
            heading.HeadingUrl = JobManager.MakeUrl(model.Heading.HeadingName);
            heading.IsApproved = false;
            heading.IsDeleted = false;
            heading.IsHome = false;
                
            
             
            List <AuthorHeading> authorHeadings  = new List<AuthorHeading>();

            //yardımcı yazar
            if (model.AuthorId!=0)
            {

                authorHeadings.Add(new AuthorHeading()
                {
                    AuthorId = model.AuthorId,
                    HeadingId = heading.HeadingId
                });
            }
            //oluşturan yazar
            authorHeadings.Add(new AuthorHeading()
            {
                AuthorId = author.AuthorId,
                HeadingId = heading.HeadingId
            });
            heading.AuthorHeadings = authorHeadings;
            int[] authorIds = { model.AuthorId, author.AuthorId };
            _headingService.Add(heading, authorIds);

            return RedirectToAction("Index");

        }



    }
}
