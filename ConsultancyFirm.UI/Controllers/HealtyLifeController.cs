using ConsultancyFirm.BL.Abstract;
using ConsultancyFirm.UI.Models;
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
        //public IActionResult a()
        //{
        //    return View();
        //}

        public IActionResult List(string category)
        {
            var headingCards = _headingService.GetHeadingByCategories(category);
            List<HeadingCardModel> headingCardModels = new List<HeadingCardModel>();

            foreach (var heading in headingCards)
            {
                HeadingCardModel headingCardModel = new HeadingCardModel()
                {
                    HeadingModel = heading,
                    AuthorsModel = heading.AuthorHeadings.Select(i => i.Author).ToList()

                };
                headingCardModels.Add(headingCardModel);
            }
            return View(headingCardModels);
         
        }



    }
}
