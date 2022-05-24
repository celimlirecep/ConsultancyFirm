using ColsultancyFirm.DAL.Abstract;
using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ColsultancyFirm.DAL.Concreate.EFCore
{
    public class EFCoreHomeSliderRespository : EFCoreBaseRepository<HomeSlider, ConsultantFirmContext>, IHomeSliderRepository
    {
        
    }
}
