using EBook.Data.Abstract;
using EBook.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Data.Concrate.EfCore
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, BookContext>, ICategoryRepository
    {
    }
}
