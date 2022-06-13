using ColsultancyFirm.DAL.Abstract;
using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColsultancyFirm.DAL.Concreate.EFCore
{
    public class EFCoreMessageRepository : EFCoreBaseRepository<Message>, IMessageRepository
    {
        public EFCoreMessageRepository(ConsultantFirmContext context) : base(context)
        {

        }
        private ConsultantFirmContext ConsultantFirmContext
        {
            get { return _context as ConsultantFirmContext; }
        }
    }
}
