using ConsultancyFirm.BL.Abstract;
using ConsultancyFirm.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHeadingService _headingService;
        public HomeController(IHeadingService headingService)
        {
            _headingService = headingService;
        }

        public IActionResult HomePage()
        {
            return View(_headingService.GetHomePageHeadings());
        }


    }
}
