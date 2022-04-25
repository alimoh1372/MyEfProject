using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using MyEfProject_Model.Models;

namespace MyEfProject_DataAccess.FluentApiConfigurations
{
    public class AuthorBookFluentApiConfiguration : IEntityTypeConfiguration<AuthorBook>
    {
        public void Configure(EntityTypeBuilder<AuthorBook> builder)
        {
            builder
                 .HasKey(b => new { b.Author_Id, b.Book_Id });
        }
    }
}
