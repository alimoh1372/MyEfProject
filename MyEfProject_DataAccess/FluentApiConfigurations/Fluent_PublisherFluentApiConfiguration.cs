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
    class Fluent_PublisherFluentApiConfiguration : IEntityTypeConfiguration<Fluent_Publisher>
    {
        public void Configure(EntityTypeBuilder<Fluent_Publisher> builder)
        {
            builder.HasKey(c => c.Publisher_Id);
            builder.Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(400);
            builder.Property(c => c.Location)
                .IsRequired()
                .HasMaxLength(800);
        }
    
    }
}
