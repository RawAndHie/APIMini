namespace ASM2.Model
{
    public class Category
    {
        public int ID { get; set; }

        public string CategoryName { get; set; }

        public Product  Product { get; set; }
    }
}
