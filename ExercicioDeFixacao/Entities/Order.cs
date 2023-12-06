using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using ExercicioDeFixacao.Entities.Enums;
namespace ExercicioDeFixacao.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }
        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void addItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void removeItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public double total()
        {
            double total = 0.0;
            foreach (OrderItem item in Items)
            {
                total += item.SubTotal();
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n-----------------------\nORDER SUMARY:\n");
            sb.AppendLine($"Order moment: {Moment}");
            sb.AppendLine($"Order status: {Status}");
            sb.AppendLine($"Client: {Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            sb.AppendLine("\n-----------------------\nOrder items:\n");
            foreach (OrderItem item in Items)
            {
                sb.Append(item.ToString());
            }
            sb.AppendLine($"-----------------------\nTotal price: ${total()}");
            return sb.ToString();
        }
    }
}
