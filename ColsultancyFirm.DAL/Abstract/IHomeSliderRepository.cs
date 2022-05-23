﻿using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColsultancyFirm.DAL.Abstract
{
    public interface IHomeSliderRepository:IBaseRepository<HomeSlider>
    {
        List<HomeSlider> GetIsVisible();
    }
}
