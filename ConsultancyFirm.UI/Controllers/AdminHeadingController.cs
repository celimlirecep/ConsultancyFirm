using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Controllers
{
    public class AdminHeadingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
