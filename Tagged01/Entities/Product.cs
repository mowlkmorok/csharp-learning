using System.Globalization;
namespace Tagged01.Entities
{

    class Product
    {
        
        public Product(){}

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string? Name { get; set; }
        public double Price { get; set; }

        public virtual string priceTag()
        {
            return $"{this.Name} $ {this.Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }

        
    }
    
}