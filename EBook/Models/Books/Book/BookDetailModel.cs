using EBook.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBook.Models
{
    public class BookDetailModel
    {   
        public Book Book { get; set; }      
        public Author Author { get; set; }
        public List<Category> Category { get; set; }
    }
}
