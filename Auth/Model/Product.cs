namespace Auth.Model
{
    public class Product
    {
        //ProducID, ProductName, Price, Unit, Status
        public int ID { get; set; }
        public string? ProductName { get; set; }
        public float Price { get; set; }

        public int Unit { get; set; }
        public int Status { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
