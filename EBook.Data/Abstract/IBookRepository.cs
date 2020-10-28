using EBook.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Data.Abstract
{
    public interface IBookRepository:IRepository<Book>
    {
        Book GetBookDetails(string Url);        
        Book GetBookReadDetails(int id);
        List<Book> GetBooksByCategory(string name,int page,int pageSize);
        int GetCountByCategory(string category);
        List<Book> GetAllMiddle();
        object GetCategoryBook(Category category);
    }
}
