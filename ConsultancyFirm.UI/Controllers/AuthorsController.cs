using ConsultancyFirm.BL.Abstract;
using ConsultancyFirm.UI.Models;
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
        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService;
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
                },
                Authors = _authorService.GetProductWithPages(page, pageSize),
                
                SelectedAuthor = id!=0? _authorService.GetById(id):null
            };
            return View(authorListViewModel);
        }
    }
}
