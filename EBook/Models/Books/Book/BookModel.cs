using EBook.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBook.Models
{
    public class BookModel
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Url { get; set; }
        public string Author { get; set; }
        public string Image { get; set; }
        public double? Pages { get; set; }//? koymasaydım 0 olarak alırdı ve işlevsel olmazdı
        public string Description { get; set; }
        public string Door { get; set; }
        public string Moduls1 { get; set; }
        public string Moduls2 { get; set; }
        public string Moduls3 { get; set; }
        public string Moduls4 { get; set; }
        public List<Category> categories { get; set; }
        public List<BookCategory> BookCategories { get; set; }
    }
}
