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
        private readonly IUnitOfWork _unitOfWork;
        public HomeSliderManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<HomeSlider> GetAllVisible()
        {
            return _unitOfWork.HomeSliders.Get(x => x.IsVisible == true);
        }
    }
}
