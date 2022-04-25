using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyEfProject_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEfProject_DataAccess.FluentApiConfigurations
{
    class Fluent_AuthorBookFluentApiConfiguration : IEntityTypeConfiguration<Fluent_AuthorBook>
    {
        public void Configure(EntityTypeBuilder<Fluent_AuthorBook> builder)
        {
            builder
                .HasKey(AuBo => new { AuBo.FkAuthor_Id, AuBo.FkBook_Id });

            //Many To Many FluentAuthorsToBooks

            //First OneToMany Fluent_BooksToFluent_AuthorBook

            builder
                .HasOne(ab => ab.Fluent_Book)
                .WithMany(ab => ab.Fluent_AuthorBooks)
                .HasForeignKey(ab => ab.FkBook_Id);


            //second Other oneToMany Relation Fluent_AuthorToFluentAuthorBook

            builder
                .HasOne(ab => ab.Fluent_Author)
                .WithMany(ab => ab.Fluent_AuthorBooks)
                .HasForeignKey(ab => ab.FkAuthor_Id);

        }
    
    }
}
