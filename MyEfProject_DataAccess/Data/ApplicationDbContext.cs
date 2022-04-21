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
    }
}
