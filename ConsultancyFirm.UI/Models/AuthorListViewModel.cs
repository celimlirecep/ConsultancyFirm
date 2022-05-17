using ConsultancyFirm.EL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultancyFirm.UI.Models
{
    public class AuthorListViewModel
    {
        public List<Author> Authors { get; set; }
        public PageInfo PageInfo { get; set; }
        public Author SelectedAuthor { get; set; }


    }

    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        //public string CurrentCategory { get; set; }
        public int TotalPages()
        {
            return (int)Math.Ceiling((decimal)TotalItems/ItemsPerPage);
        }
    }
}
