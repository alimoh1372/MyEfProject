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
    public class Fluent_AuthorFluentApiConfiguration : IEntityTypeConfiguration<Fluent_Author>
    {
        public void Configure(EntityTypeBuilder<Fluent_Author> builder)
        {
            builder.HasKey(c => c.Author_Id);
            builder.ToTable("FluentAutorTable");
            builder.Property(c => c.FirstName)
                .IsRequired()
                .HasMaxLength(400)
                .HasColumnName("First_Name");
            builder.Property(c => c.LastName)
               .IsRequired();
            builder.Property(c => c.Location)
               .IsRequired();
            builder.Ignore(c => c.FullName);
        }
    }
}