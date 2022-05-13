using ConsultancyFirm.BL.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Controllers
{
    public class HealtyLifeController : Controller
    {
        private IHeadingService _headingService;
        public HealtyLifeController(IHeadingService headingService)
        {
            _headingService = headingService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(string category)
        {
            return View(_headingService.GetHeadingByCategories(category));
         
        }



    }
}
