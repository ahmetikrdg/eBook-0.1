using EBook.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBook.Models
{
    public class BauthorDetailModel
    {
        public Bauthor Bauthor { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}       
