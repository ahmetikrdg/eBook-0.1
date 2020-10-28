using EBook.Data.Abstract;
using EBook.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBook.Data.Concrate.EfCore
{
    public class EfCoreAuthorRepository : EfCoreGenericRepository<Author, BookContext>, IAuthorRepository
    {
        public Author GetAuthorDetails(string Url)
        {
            using(var context=new BookContext())
            {
                return context.Authors.Where(i => i.Url == Url).Include(i => i.BookAuthors).ThenInclude(i => i.Book).FirstOrDefault();
            }
        }
    }                                   
}
