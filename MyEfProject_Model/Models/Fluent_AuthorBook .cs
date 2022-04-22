using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyEfProject_Model.Models
{
   public class Fluent_AuthorBook
    {
       
        public int FkBook_Id { get; set; }
      
        public int FkAuthor_Id { get; set; }

        public Fluent_Book Fluent_Book { get; set; }

        public Fluent_Author Fluent_Author { get; set; }

    }
}
