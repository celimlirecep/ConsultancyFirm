using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.BL.Abstract
{
    public interface IJobService
    {
        public string UploadImage(IFormFile file,string path);
        public string MakeUrl(string url);
    }
}
