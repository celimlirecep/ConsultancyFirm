using ColsultancyFirm.DAL.Abstract;
using ConsultancyFirm.BL.Abstract;
using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.BL.Concreate
{
    public class HomeSliderManager : IHomeSliderService
    {
        private IHomeSliderRepository  _homeSliderRepository;

        public HomeSliderManager(IHomeSliderRepository homeSliderRepository)
        {
            _homeSliderRepository = homeSliderRepository;
        }

        public List<HomeSlider> GetAllVisible()
        {
            return _homeSliderRepository.Get(x => x.IsVisible == true);
        }
    }
}
