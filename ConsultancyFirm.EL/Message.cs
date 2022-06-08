using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.EL
{
    public class Message
    {
        public int MessageId { get; set; }
        public string MessageFrom { get; set; }
        public string MessageTo { get; set; }
        public string MessageTitle { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageSendDate { get; set; }


    }
}
