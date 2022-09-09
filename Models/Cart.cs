namespace ProjectReactWeb.Models
{
    public class Cart
    {
        public int Cartid { get; set; }
        public int? Userid { get; set; }
        public int? Productid { get; set; }
        public string ProductImage { get; set; }
        public string Productname { get; set; }
        public string Brand { get; set; }

        public string ProductDesc { get; set; }
        public float Price { get; set; }
    }
}
