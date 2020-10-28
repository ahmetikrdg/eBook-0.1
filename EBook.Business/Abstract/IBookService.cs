using EBook.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Abstract
{
    public interface IBookService
    {
        Book GetById(int id);
        List<Book> GetAll();
        void Create(Book Entity);
        void Update(Book Entity);
        void Delete(Book Entity);
        Book GetBookDetails(string Url);
        Book GetBookReadDetails(int id);
        List<Book> GetBooksByCategory(string name, int page, int pageSize);
        int GetCountByCategory(string category);
        List<Book> GetAllMiddle();
        object GetCategoryBook(Category category);
    }
}
