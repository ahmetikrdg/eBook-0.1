﻿using EBook.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBook.Models
{
    public class AuthorDetailModel
    {
        public Author Author { get; set; }
        public List<Book> Books { get; set; }       
    }
}
