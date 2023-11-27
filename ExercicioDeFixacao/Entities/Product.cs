using ExercicioDeFixacao.Entities;
namespace ExercicioDeFixacao.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product product { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
