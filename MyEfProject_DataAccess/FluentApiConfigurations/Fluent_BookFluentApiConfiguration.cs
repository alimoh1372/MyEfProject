using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyEfProject_Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace MyEfProject_DataAccess.FluentApiConfigurations
{
    public class Fluent_BookFluentApiConfiguration : IEntityTypeConfiguration<Fluent_Book>
    {
        public void Configure(EntityTypeBuilder<Fluent_Book> builder)
        {
            builder.HasKey(c => c.Book_Id);
            builder.Property(c => c.ISBN)
                .IsRequired()
                .HasMaxLength(15);
            builder.Property(c => c.Price)
               .IsRequired();
            builder.Ignore(c => c.PriceRange);
            builder.Property(c => c.Tittle)
              .IsRequired()
              .HasMaxLength(400);
            builder
                 .HasOne(b => b.Fluent_BookDetail)
                 .WithOne(b => b.Fluent_Book)
                 .HasForeignKey<Fluent_BookDetail>("FkFluentBookDetail_Id");
                

        }
    }
}
