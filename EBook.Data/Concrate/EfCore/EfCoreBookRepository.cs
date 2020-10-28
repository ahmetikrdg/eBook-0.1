using EBook.Data.Abstract;
using EBook.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EBook.Data.Concrate.EfCore
{
    public class EfCoreBookRepository : EfCoreGenericRepository<Book, BookContext>, IBookRepository
    {
        public List<Book> GetAllMiddle()
        {
            using (var context = new BookContext())
            {
                return context.Bookses.Skip(1).Take(2).ToList();
            }
        }

        public Book GetBookDetails(string Url)
        {
            using(var context=new BookContext())
            {
                return context.Bookses
                    .Where(i => i.Url == Url)
                    .Include(i => i.BookCategories).ThenInclude(i => i.Categories)
                    .Include(i=>i.BookAuthors).ThenInclude(i=>i.Author)
                    .FirstOrDefault();
            }
        }

        public Book GetBookReadDetails(int id)
        {
            using (var context = new BookContext())
            {
                return context.Bookses
                    .Where(i => i.BookId == id)
                    .Include(i => i.BookCategories).ThenInclude(i => i.Categories).FirstOrDefault();
            }
        }

        public List<Book> GetBooksByCategory(string name, int page, int pageSize)
        {
            using(var context= new BookContext())
            {
                var book= context
                .Bookses        
                .AsQueryable();//asquarible biz sorguyu yazıyoruz ama vtye göndermeden önce üzerine ekstra link kriter belirlemek istiyorum demek
                if (!string.IsNullOrEmpty(name))
                {
                    book=book//ürün bilgilerinin
                    .Include(i=>i.BookCategories)//productcategorislerini
                    .ThenInclude(i=>i.Categories)//sonra kategorilerini yüklüyoruz.Daha sonra şart ekleyeceğiz şart en son çünkü ilgili kayıtların referanslarına ulaşmam lazım
                    .Where(i=>i.BookCategories.Any(a=>a.Categories.Url==name));//ilgili kaydın productcategorislerine gidiyoruz kategorilerine geçiyoruz ve gönderdiğimiz kategoriye ait bir ürün varsa any bana true döndürür oda o ürünü bana getir demek 
                }
                return book.Skip((page-1)*pageSize).Take(pageSize).ToList();
            }
        }

        public object GetCategoryBook(Category category)
        {
            string k = category.Url.ToString();
            using(var context= new BookContext())
            {
                var books = context.Bookses
                    .Include(i => i.BookCategories)
                    .ThenInclude(i => i.Categories).Where(i => i.BookCategories.Any(a => a.Categories.Url == k));
                return books.Take(6).ToList();
            }
        }

        public int GetCountByCategory(string category)
        {
            using (var context = new BookContext())
            {
                var book = context.Bookses.AsQueryable();//asquarible biz sorguyu yazıyoruz ama vtye göndermeden önce üzerine ekstra link kriter belirlemek istiyorum demek
                if (!string.IsNullOrEmpty(category))//kategori boş değilse kategoriye göre filitrele
                {
                    book = book//ürün bilgilerinin
                    .Include(i => i.BookCategories)//productcategorislerini
                    .ThenInclude(i => i.Categories)//sonra kategorilerini yüklüyoruz.Daha sonra şart ekleyeceğiz şart en son çünkü ilgili kayıtların referanslarına ulaşmam lazım
                    .Where(i => i.BookCategories.Any(a => a.Categories.Url == category));//ilgili kaydın productcategorislerine gidiyoruz kategorilerine geçiyoruz ve gönderdiğimiz kategoriye ait bir ürün varsa any bana true döndürür oda o ürünü bana getir demek 
                }
                return book.Count();
            }
        }
    }
}
