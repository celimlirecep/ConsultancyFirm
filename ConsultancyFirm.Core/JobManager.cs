
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultancyFirm.Core
{
    public static class JobManager
    {
        /// <summary>
        /// String İfadeyi URL formatına dönüştürür
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static string MakeUrl(string url)
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
        /// <summary>
        /// Resim dosyalarının alınıp istenilen klasörde depolanmasını sağlar
        /// </summary>
        /// <param name="file"></param>
        /// <param name="pathImage"></param>
        /// <returns></returns>
        public static string UploadImage(IFormFile file,string pathImage)
        {
            var extension = Path.GetExtension(file.FileName);
            string randomName = string.Format($"{Guid.NewGuid()}-{file.FileName}{extension}");
            var path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{pathImage}", randomName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);
            }
            return $"/images/{pathImage}/{randomName}";
        }

        public static string CreateMessage(string title, string message, string alertType)
        {
            var msg = new AlertMessage()
            {
                Title = title,
                Message = message,
                AlertType = alertType
            };
            return JsonConvert.SerializeObject(msg);
        }


    }
}
