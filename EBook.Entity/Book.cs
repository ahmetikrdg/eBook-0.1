using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entity
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        public double? Pages { get; set; }//? koymasaydım 0 olarak alırdı ve işlevsel olmazdı
        public string Description { get; set; }
        public string Tags { get; set; }    
        public string IssApproved { get; set; }

        public List<BookCategory> BookCategories { get; set; }
        public List<BookAuthor> BookAuthors { get; set; }
    }
}
