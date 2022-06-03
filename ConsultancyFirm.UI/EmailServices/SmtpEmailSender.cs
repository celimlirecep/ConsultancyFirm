using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.EmailServices
{
    public class SmtpEmailSender : IEmailSender
    {

        //appsettingjsondan bu veriler başlangıçta çekilecek
        private string _host;
        private int _port;
        private bool _enableSSL;
        private string _userName;
        private string _password;

        public SmtpEmailSender(string host, int port, bool enableSSL, string userName, string password)
        {
            _host = host;
            _port = port;
            _enableSSL = enableSSL;
            _userName = userName;
            _password = password;
        }

        public Task SenderEmailAsync(string email, string subject, string htmlMessage)
        {
            //constructure da çekilen bilgilere göre client oluşturuldu
            var client = new SmtpClient(this._host, this._port)
            {
                Credentials=new NetworkCredential(this._userName,this._password),
                EnableSsl=this._enableSSL
            };
            //client tarafından mail gönderme işlemi(admin)
            return client.SendMailAsync(
                new MailMessage(this._userName, email, subject, htmlMessage)
                {
                    IsBodyHtml=true
                }
                );
        }
    }
}
