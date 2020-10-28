using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Entity
{
    public class BlogAuthor
    {
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public int BauthorId { get; set; }
        public Bauthor Bauthor { get; set; }        
    }
}
