using EBook.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Data.Abstract
{
    public interface IAuthorRepository:IRepository<Author>
    {
        Author GetAuthorDetails(string Url);            

    }
}
