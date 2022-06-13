using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColsultancyFirm.DAL.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
        ICategoryRepository Categories { get; }
        IAuthorRepository Authors { get; }
        IHeadingRepository Headings { get; }
        IHomeSliderRepository HomeSliders { get; }
        IMemberServiceRepository MemberServices { get; }
        IMessageRepository Messages { get; }
        
        void save();
    }
}
