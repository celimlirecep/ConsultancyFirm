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
        private readonly IHomeSliderService _homeSliderService;
        public HomeController(IHeadingService headingService, IHomeSliderService homeSliderService)
        {
            _headingService = headingService;
            _homeSliderService = homeSliderService;
        }

        public IActionResult HomePage()
        {
            var headingCards = _headingService.GetHomePageHeadings();
            List<HeadingCardModel> headingCardModels = new List<HeadingCardModel>();

            foreach (var heading in headingCards) {
               HeadingCardModel headingCardModel= new HeadingCardModel()
                {
                    HeadingModel = heading,
                    AuthorsModel = heading.AuthorHeadings.Select(i => i.Author).ToList()

                };
                headingCardModels.Add(headingCardModel);
            }

            ViewData["HomeSlider"] = _homeSliderService.GetAllVisible();

            return View(headingCardModels);
        }


    }
}
