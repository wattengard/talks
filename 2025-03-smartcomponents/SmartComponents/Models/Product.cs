namespace SmartComponents.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
        public StockState Status { get; set; }
        public double Score { get; set; }

        public Product(string name, string category, decimal price, StockState status, double score)
        {
            Name = name;
            Category = category;
            Price = price;
            Status = status;
            Score = score;
        }

        public override string ToString()
        {
            return $"{Name} - {Category} - {Price} NOK - {Status} - {Score}/5";
        }
    }

    public class ProductList
    {
        public List<Product> Products { get; set; }
    }

}
