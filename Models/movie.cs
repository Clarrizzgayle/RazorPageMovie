using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPageMovie.Models

{
    public class movie
    {
        public int ID { get; set; }
        public string Title { get; set; }= String.Empty;    
        
        [DataType(DataType.Date)]
        public DateTime DateRelease { get; set; }
        public string Genre { get; set; }= String.Empty;
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }  
    }
}
