namespace Auth.Model
{
    public class Category
    {
        public int ID { get; set; }

        public string CategoryName { get; set; }

        public Product  Product { get; set; }
    }
}
