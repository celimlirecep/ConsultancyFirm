using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.BL.Abstract
{
    public interface IMemberService:IJobService
    {
        Member GetById(int id);
        List<Member> GetAll();
        void Update(Member entity);
        void Delete(Member entity);
        void Add(Member entity);
        Member GetSingle(Expression<Func<Member, bool>> filter);
       
    }
}
