using System;
using System.Globalization;
using System.Text;

namespace ExercicioDeFixacao.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() 
        {
        }
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Product.Name}, ");
            sb.Append($"${Price.ToString("F2", CultureInfo.InvariantCulture)}, ");
            sb.Append($"Quantity: {Quantity.ToString()}, ");
            sb.AppendLine($"Subtotal: ${SubTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
