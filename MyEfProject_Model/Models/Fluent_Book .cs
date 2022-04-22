using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEfProject_Model.Models
{


  public  class Fluent_Book
    {
       
        public int Book_Id { get; set; }
     
        public string Tittle { get; set; }
     
        public string ISBN { get; set; }
        
        public double Price { get; set; }
       
        public string PriceRange { get; set; }
        public int FluentBookDetail_Id { get; set; }

        public Fluent_BookDetail Fluent_BookDetail { get; set; }

        public int Fluent_PublisherFkId { get; set; }

        public Fluent_Publisher Fluent_Publisher { get; set; }


        public ICollection<Fluent_AuthorBook> Fluent_AuthorBooks { get; set; }

    }
}
