using ConsultancyFirm.BL.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.ViewComponents
{
    public class AuthorsViewComponent:ViewComponent
    {
        private IAuthorService _authorService;
        public AuthorsViewComponent(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public IViewComponentResult Invoke()
        {
         
            return View(_authorService.GetAll());
        }

    }
}
