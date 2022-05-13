using ConsultancyFirm.BL.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Controllers
{
    public class AuthorsController : Controller
    {
        private IHeadingService _headingService;
        public AuthorsController(IHeadingService headingService)
        {
            _headingService = headingService;
        }
        public IActionResult List(string authorNameUrl)
        {
            return View(_headingService.GetHeadingByAuthors(authorNameUrl));
        }
    }
}
