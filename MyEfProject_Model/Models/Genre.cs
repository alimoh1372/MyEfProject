using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace MyEfProject_Model.Models
{
    [Table("tbl_Genres")]
  public  class Genre
    {
        [Key]
        public int GenreId { get; set; }
        [Column("Name")]
        public string GenreName { get; set; }
        
        public int DisplayOrder { get; set; }
                

    }
}
