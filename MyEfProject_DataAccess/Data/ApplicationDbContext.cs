using Microsoft.EntityFrameworkCore;
using MyEfProject_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEfProject_DataAccess.FluentApiConfigurations;

namespace MyEfProject_DataAccess.Data
{
   public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Category> Categories  { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> books { get; set; }

        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<AuthorBook> AuthorBooks { get; set; }
        public DbSet<Fluent_BookDetail> Fluent_BookDetails { get; set; }
        public DbSet<Fluent_Author> Fluent_Authors { get; set; }
        public DbSet<Fluent_Book> Fluent_Books { get; set; }
        public DbSet<Fluent_Category> Fluent_Categories { get; set; }
        public DbSet<Fluent_Publisher> Fluent_Publishers { get; set; }

        public DbSet<Fluent_AuthorBook> Fluent_AuthorBooks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AuthorBookFluentApiConfiguration());
            modelBuilder.ApplyConfiguration(new Fluent_AuthorBookFluentApiConfiguration());
            modelBuilder.ApplyConfiguration(new Fluent_AuthorFluentApiConfiguration());
            modelBuilder.ApplyConfiguration(new Fluent_BookDetailFluentApiConfiguration());
            modelBuilder.ApplyConfiguration(new Fluent_BookFluentApiConfiguration());
            modelBuilder.ApplyConfiguration(new Fluent_CategoryFluentApiConfiguration());
            modelBuilder.ApplyConfiguration(new Fluent_PublisherFluentApiConfiguration());
          
        }
    }
}
