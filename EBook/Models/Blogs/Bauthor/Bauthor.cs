using EBook.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBook.Models
{
    public class Bauthor
    {
        public int BauthorId { get; set; }      
        public string NameSurname { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public string Url { get; set; }

        public List<BlogAuthor> BlogAuthors { get; set; }
    }
}
