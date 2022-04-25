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
    public class Fluent_BookDetailFluentApiConfiguration : IEntityTypeConfiguration<Fluent_BookDetail>
    {
        public void Configure(EntityTypeBuilder<Fluent_BookDetail> builder)
        {
           builder.HasKey(b => b.BookDetail_Id);

           builder
                .Property(b => b.NumberOfChapters)
                .IsRequired();
           builder
                .Property(b => b.NumberOfPages)
                .IsRequired();
            
          
        }
    }
}
