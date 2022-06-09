using ConsultancyFirm.EL;
using ConsultancyFirm.UI.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Models
{
    public class MessageModel
    {
        public User User { get; set; }

        public List<Author> Authors { get; set; }
        public Author Author { get; set; }
        public List<Message> GetMessages { get; set; }
        public List<Message> PushMessage { get; set; }
        public Message Message { get; set; }
        public bool IsGetPage { get; set; }


    }
}
