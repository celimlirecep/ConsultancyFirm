using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index(string password)
        {
            if (password=="456")
            {
                return View();
            }
            return RedirectToAction("Index","Member");
        }
    }
}
