using EBook.Business.Abstract;
using EBook.Data.Abstract;
using EBook.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Concrate
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public void Create(Category Entity)
        {
            _categoryRepository.Create(Entity);
        }

        public void Delete(Category Entity)
        {
            _categoryRepository.Create(Entity);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public void Update(Category Entity)
        {
            _categoryRepository.Create(Entity);
        }
    }
}
