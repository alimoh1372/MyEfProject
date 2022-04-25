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
    class Fluent_CategoryFluentApiConfiguration : IEntityTypeConfiguration<Fluent_Category>
    {
        public void Configure(EntityTypeBuilder<Fluent_Category> builder)
        {
           builder.HasKey(c => c.Id);
           builder.Property(c => c.CategoryName)
                .IsRequired()
                .HasMaxLength(400);

        }
    
    }
}
