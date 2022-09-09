using System.ComponentModel.DataAnnotations;

namespace ProjectReactWeb.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string productImage { get; set; }
        public string productname { get; set; }
        
         public string Brand { get; set; }
        public int Availablecount { get; set; }
       
        public float price { get; set; }
    }
}
