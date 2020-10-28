using EBook.Business.Abstract;
using EBook.Data.Abstract;
using EBook.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Concrate
{
    public class BookManager:IBookService
    {
        private IBookRepository _bookRepository;
        public BookManager(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public void Create(Book Entity)
        {
            _bookRepository.Create(Entity);
        }

        public void Delete(Book Entity)
        {
            _bookRepository.Delete(Entity);
        }

        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public List<Book> GetAllMiddle()
        {
            return _bookRepository.GetAllMiddle();
        }

        public Book GetBookDetails(string Url)
        {
            return _bookRepository.GetBookDetails(Url);
        }

        public Book GetBookReadDetails(int id)
        {
            return _bookRepository.GetBookReadDetails(id);
        }

        public List<Book> GetBooksByCategory(string name, int page, int pageSize)
        {
            return _bookRepository.GetBooksByCategory(name, page, pageSize);
        }

        public Book GetById(int id)
        {
            return _bookRepository.GetById(id);
        }

        public object GetCategoryBook(Category category)
        {
            return _bookRepository.GetCategoryBook(category);
        }

        public int GetCountByCategory(string category)
        {
            return _bookRepository.GetCountByCategory(category);
        }

        public void Update(Book Entity)
        {
            _bookRepository.Update(Entity);
        }
    }
}
