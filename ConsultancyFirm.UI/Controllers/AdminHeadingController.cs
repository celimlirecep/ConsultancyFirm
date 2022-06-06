using ConsultancyFirm.BL.Abstract;
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

        public AdminHeadingController(IHeadingService headingService)
        {
            _headingService = headingService;
        }
        public IActionResult Index()
        {
            _headingService.GetHeadingByCategories();

            return View(_headingService.GetAll());
        }

       
    }
}
