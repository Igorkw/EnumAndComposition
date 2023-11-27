using System.Collections.Generic;
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
            return Items.Count;
        }
    }
}
