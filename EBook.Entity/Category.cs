using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entity
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Tittle { get; set; }
        public string Url { get; set; } 

        public List<BookCategory> BookCategories { get; set; }
    }
}
