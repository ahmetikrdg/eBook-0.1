using EBook.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBook.ViewComponents
{
    public class BookMiddleViewComponent:ViewComponent
    {
        private IBookService _bookService;
        public BookMiddleViewComponent(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IViewComponentResult Invoke()
        {
            var model = new EBook.Models.BookListViewModel
            {
                pageInfo=null,
                Books = _bookService.GetAllMiddle()
            };
            return View(model);
        }
    }
}
