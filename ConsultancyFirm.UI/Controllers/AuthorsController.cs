using ConsultancyFirm.BL.Abstract;
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
    public class AuthorsController : Controller
    {
        private IAuthorService _authorService;
        private UserManager<User> _userManager;

        public AuthorsController(IAuthorService authorService, UserManager<User> userManager)
        {
            _authorService = authorService;
            _userManager = userManager;
        }

        public IActionResult List(int page=1,int id=0)
        {
            const int pageSize = 2;
            int totalItems = _authorService.GetAll().Count();
            var authorListViewModel = new AuthorListViewModel()
            {
                PageInfo = new PageInfo
                {
                    TotalItems = totalItems,
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                }



               
            };

            var authors = _authorService.GetAuthorsWithPages(page, pageSize);
            var users = _userManager.Users.ToList();
            authorListViewModel.AuthorInfos = new List<AuthorInfo>();
            foreach (var author in authors)
            {
                var authorInfo = new AuthorInfo()
                {
                    AuthorId=author.AuthorId,
                    FullName = author.AuthorFullName,
                    Email = users.Find(i => i.Id == author.UserId).Email,
                    About = author.AuthorAbout,
                    Image = users.Find(i => i.Id == author.UserId).MemberImage
                };
                authorListViewModel.AuthorInfos.Add(authorInfo);

            }

            authorListViewModel.SelectedAuthor = id != 0 ? authorListViewModel.AuthorInfos.Find(i => i.AuthorId == id) : null;
            return View(authorListViewModel);
        }
    }
}
