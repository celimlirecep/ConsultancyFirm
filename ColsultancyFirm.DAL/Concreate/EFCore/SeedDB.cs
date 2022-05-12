using Microsoft.EntityFrameworkCore;
using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColsultancyFirm.DAL.Concreate.EFCore
{
    public static class SeedDB
    {
        public static void Seed()
        {
            var context = new ConsultantFirmContext();
            if (context.Database.GetPendingMigrations().Count()==0)
            {
                if (context.Headings.Count()==0)
                {
                    context.Headings.AddRange(Headings);
                }
                if (context.Categories.Count()==0)
                {
                    context.Categories.AddRange(Categories);
                }
                if (context.Authors.Count() == 0)
                {
                    context.Authors.AddRange(Authors);
                }
                if (context.AuthorHeadings.Count() == 0)
                {
                    context.AuthorHeadings.AddRange(AuthorHeadings);
                }
                context.SaveChanges();
            }
        }


        private static Heading[] Headings =
        {
            new Heading(){HeadingName="Kişiye Özel Danışmanlık Hizmetleri",HeadingContent="Bilgi almak istediğiniz alanlarla ilgili uzmanların profillerini detaylı inceleyin, size en uygun online danışmanları bulun.",HeadingUrl="kisiye-ozel-danismanlik-hizmeti"  },

            new Heading(){HeadingName="Kilo Nasıl Verilir",HeadingContent="Acı çekmeden kilo vermek, verilen kiloların ise vücut formunu bozmadan kalıcılığını sağlamak için uzman desteği önemlidir. Diyetisyen ve sağlıklı beslenme uzmanları kişiye özel menüleri ve tavsiyeleri ile fazla kilolara veda etmenizi, ihtiyacınız var ise kilo almanızı sağlar.",HeadingUrl="kilo-nasil-verilir"},

            new Heading(){HeadingName="Online Astrolog Hizmetlerimizle Yanınızdayız",HeadingContent="Yaşanan retrolara, gezegenlerin, ayın ve güneşin konumuna göre gününü ayarlayan herkesin bölümü astroloji, Danışmanya uzmanları sayesinde çok daha fazla gündeminizi meşgul eder. Doğum haritalarının uzman astrologlar tarafından yorumlanması, ilişkinize dair uyum ve önünüzdeki kararlardaki en önemli kritik anlar için mutlaka danismanya.com astrologlarına danışın.",HeadingUrl="online-astrolog-hizmetlerimizle-yaninizdayiz"},

            new Heading(){HeadingName="Çocuk-Ergen-Yetişkin Terapisi",HeadingContent="Psikolojik destek ile ilgili randevu almak için hizmetler bölümünde telefon numarasından randevu alabilirsiniz. Sormak istediklerinizi mail ile sorabilirsiniz.",HeadingUrl="cocuk-ergen-yetiskin-terapisi"},

            new Heading(){HeadingName="Pisikolojik Tedavi İçin Tek Çözüm Yolu",HeadingContent="Eğitim hayatım boyunca ve sonrasında kendimi geliştirmek, psikoloji alanındaki deneyimlerimi artırmak amaçlı birçok projede gönüllü olarak yer aldım ve hastanelerde stajyer psikolog olarak görev yapma fırsatı buldum.",HeadingUrl="pisikolojik-tedavi-icin-tek-cözüm-yolu"}
        };

        private static Author[] Authors =
        {
            new Author(){
            AuthorName="Recep",
            AuthorSurname="Çelimli",
            AuthorPhone="5315489845",
            AuthorImages="recep.jpg",
            AuthorMail="recep@hotmail.com",
            AuthorUrl="recep"
            
            },
             new Author(){
            AuthorName="Mikail",
            AuthorSurname="Ayan",
            AuthorPhone="5315434845",
            AuthorImages="mikail.jpg",
            AuthorMail="mikail@hotmail.com",
             AuthorUrl="mikail"
            },
              new Author(){
            AuthorName="Asli",
            AuthorSurname="Aytaç",
            AuthorPhone="5315489878",
            AuthorImages="asli.jpg",
            AuthorMail="asli@hotmail.com",
             AuthorUrl="asli"

            },
               new Author(){
            AuthorName="Ebubekir",
            AuthorSurname="Rençber",
            AuthorPhone="5315489985",
            AuthorImages="ebubekir.jpg",
            AuthorMail="ebubekir@hotmail.com",
             AuthorUrl="ebubekir"
            },
           
                             new Author(){
            AuthorName="Okan",
            AuthorSurname="Karakoç",
            AuthorPhone="5315489985",
            AuthorImages="okan.jpg",
            AuthorMail="okan@hotmail.com",
            AuthorUrl="okan"
            },
        };

        private static AuthorHeading[] AuthorHeadings =
        {
            new AuthorHeading(){Author=Authors[0],Heading=Headings[1]},
            new AuthorHeading(){Author=Authors[0],Heading=Headings[2]},
            new AuthorHeading(){Author=Authors[1],Heading=Headings[3]},
            new AuthorHeading(){Author=Authors[2],Heading=Headings[4]},
            new AuthorHeading(){Author=Authors[2],Heading=Headings[1]},
            new AuthorHeading(){Author=Authors[3],Heading=Headings[1]},
            new AuthorHeading(){Author=Authors[3],Heading=Headings[0]},
            new AuthorHeading(){Author=Authors[4],Heading=Headings[3]},
            new AuthorHeading(){Author=Authors[4],Heading=Headings[2]},
            
        };

        private static Category[] Categories =
        {
            new Category(){CategoryName="Diyetisyen",CategoryDesription="Kilo vermenizi sağlar",CategoryUrl="diyetisyen"},
            new Category(){CategoryName="Astrolog",CategoryDesription="Kilo vermenizi sağlar",CategoryUrl="astrolog"},
            new Category(){CategoryName="Yaşam Koçu",CategoryDesription="Kilo vermenizi sağlar",CategoryUrl="yasam-kocu"},
            new Category(){CategoryName="Cinsel Sağlık ",CategoryDesription="Kilo vermenizi sağlar",CategoryUrl="cinsel-saglık-uzmanı"},
            new Category(){CategoryName="Finans Uzmanı",CategoryDesription="Kilo vermenizi sağlar",CategoryUrl="finans-uzmanı"},
            new Category(){CategoryName="Bilişim ",CategoryDesription="Kilo vermenizi sağlar",CategoryUrl="bilisim-uzmanı"},
            new Category(){CategoryName="Sağlıklı Yaşam",CategoryDesription="Kilo vermenizi sağlar",CategoryUrl="saglıklı-yasam-fitness"},
            new Category(){CategoryName="Spiritüel Enerji ",CategoryDesription="Kilo vermenizi sağlar",CategoryUrl="spirutuel-enerji-uygulamakarı"}

        };
            
            



    }
}
