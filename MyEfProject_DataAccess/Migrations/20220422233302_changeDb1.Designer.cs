﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyEfProject_DataAccess.Data;

namespace MyEfProject_DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220422233302_changeDb1")]
    partial class changeDb1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("MyEfProject_Model.Models.Author", b =>
                {
                    b.Property<int>("Author_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Author_Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.AuthorBook", b =>
                {
                    b.Property<int>("Author_Id")
                        .HasColumnType("int");

                    b.Property<int>("Book_Id")
                        .HasColumnType("int");

                    b.HasKey("Author_Id", "Book_Id");

                    b.HasIndex("Book_Id");

                    b.ToTable("AuthorBooks");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Book", b =>
                {
                    b.Property<int>("Book_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BookDetail_Id")
                        .HasColumnType("int");

                    b.Property<int>("Category_Id")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Publisher_Id")
                        .HasColumnType("int");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Book_Id");

                    b.HasIndex("BookDetail_Id")
                        .IsUnique();

                    b.HasIndex("Category_Id");

                    b.HasIndex("Publisher_Id");

                    b.ToTable("books");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.BookDetail", b =>
                {
                    b.Property<int>("BookDetail_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("NumberOfChapters")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("BookDetail_Id");

                    b.ToTable("BookDetails");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Fluent_Author", b =>
                {
                    b.Property<int>("Author_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)")
                        .HasColumnName("First_Name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Author_Id");

                    b.ToTable("FluentAutorTable");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Fluent_AuthorBook", b =>
                {
                    b.Property<int>("FkAuthor_Id")
                        .HasColumnType("int");

                    b.Property<int>("FkBook_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Book_Id")
                        .HasColumnType("int");

                    b.HasKey("FkAuthor_Id", "FkBook_Id");

                    b.HasIndex("Book_Id");

                    b.HasIndex("FkBook_Id");

                    b.ToTable("Fluent_AuthorBooks");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Fluent_Book", b =>
                {
                    b.Property<int>("Book_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("FluentBookDetail_Id")
                        .HasColumnType("int");

                    b.Property<int>("Fluent_PublisherFkId")
                        .HasColumnType("int");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("Book_Id");

                    b.HasIndex("FluentBookDetail_Id")
                        .IsUnique();

                    b.HasIndex("Fluent_PublisherFkId");

                    b.ToTable("Fluent_Books");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Fluent_BookDetail", b =>
                {
                    b.Property<int>("BookDetail_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("NumberOfChapters")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfPages")
                        .HasColumnType("int");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("BookDetail_Id");

                    b.ToTable("Fluent_BookDetails");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Fluent_Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("Id");

                    b.ToTable("Fluent_Categories");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Fluent_Publisher", b =>
                {
                    b.Property<int>("Publisher_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(800)
                        .HasColumnType("nvarchar(800)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("Publisher_Id");

                    b.ToTable("Fluent_Publishers");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Genre", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("GenreName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.HasKey("GenreId");

                    b.ToTable("tbl_Genres");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Publisher", b =>
                {
                    b.Property<int>("Publisher_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.HasKey("Publisher_Id");

                    b.ToTable("Publishers");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.AuthorBook", b =>
                {
                    b.HasOne("MyEfProject_Model.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("Author_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyEfProject_Model.Models.Book", "Book")
                        .WithMany()
                        .HasForeignKey("Book_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Book", b =>
                {
                    b.HasOne("MyEfProject_Model.Models.BookDetail", "BookDetail")
                        .WithOne("Book")
                        .HasForeignKey("MyEfProject_Model.Models.Book", "BookDetail_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyEfProject_Model.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("Category_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyEfProject_Model.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("Publisher_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookDetail");

                    b.Navigation("Category");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Fluent_AuthorBook", b =>
                {
                    b.HasOne("MyEfProject_Model.Models.Book", null)
                        .WithMany("Fluent_AuthorBooks")
                        .HasForeignKey("Book_Id");

                    b.HasOne("MyEfProject_Model.Models.Fluent_Author", "Fluent_Author")
                        .WithMany("Fluent_AuthorBooks")
                        .HasForeignKey("FkAuthor_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyEfProject_Model.Models.Fluent_Book", "Fluent_Book")
                        .WithMany("Fluent_AuthorBooks")
                        .HasForeignKey("FkBook_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fluent_Author");

                    b.Navigation("Fluent_Book");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Fluent_Book", b =>
                {
                    b.HasOne("MyEfProject_Model.Models.Fluent_BookDetail", "Fluent_BookDetail")
                        .WithOne("Fluent_Book")
                        .HasForeignKey("MyEfProject_Model.Models.Fluent_Book", "FluentBookDetail_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyEfProject_Model.Models.Fluent_Publisher", "Fluent_Publisher")
                        .WithMany("Fluent_Books")
                        .HasForeignKey("Fluent_PublisherFkId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fluent_BookDetail");

                    b.Navigation("Fluent_Publisher");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Book", b =>
                {
                    b.Navigation("Fluent_AuthorBooks");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.BookDetail", b =>
                {
                    b.Navigation("Book");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Category", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Fluent_Author", b =>
                {
                    b.Navigation("Fluent_AuthorBooks");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Fluent_Book", b =>
                {
                    b.Navigation("Fluent_AuthorBooks");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Fluent_BookDetail", b =>
                {
                    b.Navigation("Fluent_Book");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Fluent_Publisher", b =>
                {
                    b.Navigation("Fluent_Books");
                });

            modelBuilder.Entity("MyEfProject_Model.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
