using EBook.Business.Abstract;
using EBook.Data.Abstract;
using EBook.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Business.Concrate
{
    public class AuthorManager : IAuthorServices
    {
        private IAuthorRepository _authorRepository;
        public AuthorManager(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public void Create(Author Entity)
        {
            _authorRepository.Create(Entity);
        }

        public void Delete(Author Entity)
        {
            _authorRepository.Delete(Entity);
        }

        public List<Author> GetAll()
        {
           return _authorRepository.GetAll();
        }

        public Author GetAuthorDetails(string Url)
        {
            return _authorRepository.GetAuthorDetails(Url);
        }

        public Author GetById(int id)
        {
            return _authorRepository.GetById(id);
        }

        public void Update(Author Entity)
        {
            _authorRepository.Update(Entity);
        }
    }
}
