﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEfProject_Model.Models
{
  public  class Book
    {
        [Key]
        public int Book_Id { get; set; }
        [Required]
        [MaxLength(300)]
        public string Tittle { get; set; }
        [Required]
        [MaxLength(50)]
        public string ISBN { get; set; }
        [Required]
        public double Price { get; set; }
        [NotMapped]
        public string PriceRange { get; set; }
        [ForeignKey("Category")]
        public int  Category_Id { get; set; }

        public Category Category { get; set; }
        [ForeignKey("BookDetail")]
        public int BookDetail_Id { get; set; }

        public BookDetail BookDetail { get; set; }
        [ForeignKey("Publisher")]
        public int Publisher_Id { get; set; }

        public Publisher Publisher { get; set; }

        public ICollection<Fluent_AuthorBook> Fluent_AuthorBooks { get; set; }








    }
}
