using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entity
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Tittle { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public string IssApproved { get; set; }
        public string Url { get; set; }

        public List<BlogAuthor> BlogAuthors { get; set; }

    }
}
