﻿using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.BL.Abstract
{
    public interface IMemberService_Service : IGenericService<MemberService>
    {
        List<MemberService> GetMemberServicesBySelectedAppointmentInfo(int authorId, int  categoryId, DateTime dateTime);
        List<MemberService> GetThisDaysMemberServices();
        List<MemberService> GetMemberServicesWithAuthorsAndCategoriesByUser(string userId);
    }
}
