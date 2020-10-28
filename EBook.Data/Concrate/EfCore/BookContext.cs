using EBook.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EBook.Data.Concrate.EfCore
{
    public class BookContext:DbContext
    {
        public DbSet<Book> Bookses { get; set; }
        public DbSet<Category> Categorieses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Bauthor> Bauthors { get; set; }
        


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=DBeBookApp;integrated security=true;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookCategory>()//konumlandım
            .HasKey(c => new { c.BookId, c.CategoryId });//birincil anahtarları belirttim

            modelBuilder.Entity<BookAuthor>()
           .HasKey(c => new { c.BookId, c.AuthorId });  

            modelBuilder.Entity<BlogAuthor>()
          .HasKey(c => new { c.BlogId, c.BauthorId });     
        }
    }
}
