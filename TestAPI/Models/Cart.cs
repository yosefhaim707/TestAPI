namespace TestAPI.Models
{
    public class Cart
    {
        public int id { get; set; }
        public int userId { get; set; }
        public DateOnly date { get; set; }
        public List<Product> products { get; set; }
        
    }
}
