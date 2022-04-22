using Microsoft.EntityFrameworkCore;
using MyEfProject_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            modelBuilder.Entity<AuthorBook>()
                .HasKey(b => new { b.Author_Id, b.Book_Id });

            #region Fluent_BookDetail 
            modelBuilder.Entity<Fluent_BookDetail>().HasKey(b => b.BookDetail_Id);

            modelBuilder.Entity<Fluent_BookDetail>()
                .Property(b => b.NumberOfChapters)
                .IsRequired();
            modelBuilder.Entity<Fluent_BookDetail>()
                .Property(b => b.NumberOfPages)
                .IsRequired();
            #endregion

            #region Fluent_Author
            modelBuilder.Entity<Fluent_Author>().HasKey(c => c.Author_Id);
            modelBuilder.Entity<Fluent_Author>().ToTable("FluentAutorTable");
            modelBuilder.Entity<Fluent_Author>().Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(400)
                .HasColumnName("First_Name");
            modelBuilder.Entity<Fluent_Author>().Property(c => c.LastName)
               .IsRequired();
            modelBuilder.Entity<Fluent_Author>().Property(c => c.Location)
               .IsRequired();
            modelBuilder.Entity<Fluent_Author>().Ignore(c => c.FullName);

            #endregion
            #region Fluent_Books

            modelBuilder.Entity<Fluent_Book>().HasKey(c => c.Book_Id);
            modelBuilder.Entity<Fluent_Book>().Property(c => c.ISBN)
                .IsRequired()
                .HasMaxLength(15);
            modelBuilder.Entity<Fluent_Book>().Property(c => c.Price)
               .IsRequired();
            modelBuilder.Entity<Fluent_Book>().Ignore(c => c.PriceRange);
            modelBuilder.Entity<Fluent_Book>().Property(c => c.Tittle)
              .IsRequired()
              .HasMaxLength(400);

            modelBuilder.Entity<Fluent_Book>()
                 .HasOne(b => b.Fluent_BookDetail)
                 .WithOne(c => c.Fluent_Book)
                 .HasForeignKey<Fluent_Book>("FluentBookDetail_Id");
            //Relation OneToMany FluentPublisherToFluentBook

            modelBuilder.Entity<Fluent_Book>()
                .HasOne(b => b.Fluent_Publisher)
                .WithMany(b => b.Fluent_Books)
                .HasForeignKey(b => b.Fluent_PublisherFkId);


            
            #endregion
            #region Fluent_Category

            modelBuilder.Entity<Fluent_Category>().HasKey(c => c.Id);
            modelBuilder.Entity<Fluent_Category>().Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(400);


            #endregion
            #region Fluent_Publisher

            modelBuilder.Entity<Fluent_Publisher>().HasKey(c => c.Publisher_Id);
            modelBuilder.Entity<Fluent_Publisher>().Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(400);
            modelBuilder.Entity<Fluent_Publisher>().Property(c => c.Location)
                .IsRequired()
                .HasMaxLength(800);
            #endregion
            #region Fluent_BookDetail 

            modelBuilder.Entity<Fluent_BookDetail>().HasKey(c => c.BookDetail_Id);
            modelBuilder.Entity<Fluent_BookDetail>().Property(c => c.NumberOfChapters)
                .IsRequired();
            modelBuilder.Entity<Fluent_BookDetail>().Property(c => c.NumberOfPages)
                .IsRequired();
            #endregion
            #region Fluent_AuthorBooks 

            modelBuilder.Entity<Fluent_AuthorBook>()
                 .HasKey(AuBo => new { AuBo.FkAuthor_Id, AuBo.FkBook_Id });

            //Many To Many FluentAuthorsToBooks

            //First OneToMany Fluent_BooksToFluent_AuthorBook

            modelBuilder.Entity<Fluent_AuthorBook>()
                .HasOne(ab => ab.Fluent_Book)
                .WithMany(ab => ab.Fluent_AuthorBooks)
                .HasForeignKey(ab => ab.FkBook_Id);


            //second Other oneToMany Relation Fluent_AuthorToFluentAuthorBook

            modelBuilder.Entity<Fluent_AuthorBook>()
                .HasOne(ab => ab.Fluent_Author)
                .WithMany(ab => ab.Fluent_AuthorBooks)
                .HasForeignKey(ab => ab.FkAuthor_Id);
            #endregion




        }
    }
}
