using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.BL.Concreate
{
    public class JobManager
    {
        public string MakeUrl(string url)
        {
            url = url.Replace("I", "i");
            url = url.Replace("ı", "i");
            url = url.Replace("İ", "i");
            url = url.Replace(" ", "-");
            url = url.Replace(".", "");
            url = url.ToLower();
            url = url.Replace("ö", "o");
            url = url.Replace("ü", "u");
            url = url.Replace("ç", "c");
            url = url.Replace("ğ", "g");
            url = url.Replace("ş", "s");

            return url;
        }

        public string UploadImage(IFormFile file,string pathImage)
        {
            var extension = Path.GetExtension(file.FileName);
            string randomName = string.Format($"{Guid.NewGuid()}-{file.FileName}{extension}");
            var path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{pathImage}", randomName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            return randomName;
        }
    }
}
