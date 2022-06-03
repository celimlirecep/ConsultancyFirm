using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.EmailServices
{
    public interface IEmailSender
    {
        //Farklı mail servislerine mail gönderme üzerine tasarlandı
        Task SenderEmailAsync(string email, string subject, string htmlMessage);
    }
}
