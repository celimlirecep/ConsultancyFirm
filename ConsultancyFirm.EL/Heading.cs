using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.EL
{
    public class Heading
    {
        public int HeadingId { get; set; }
        public string HeadingName { get; set; }
        [StringLength(1000,MinimumLength =100,ErrorMessage ="İçerik uzunluğu 100-1000 karakter arasında olmalıdır!!!")]
        public string HeadingContent { get; set; }
        public string HeadingImageUrl { get; set; }
        public string HeadingUrl { get; set; }
        public DateTime HeadingPublishTime { get; set; }

        public bool IsDeleted { get; set; }
        public bool IsHome { get; set; }
        //Yazılan makaleler onaydan geçtikten sonra yayınlansın istiyorum
        public bool IsApproved { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<AuthorHeading> AuthorHeadings { get; set; }


    }
}
