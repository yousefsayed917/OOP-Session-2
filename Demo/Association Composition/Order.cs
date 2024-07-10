using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Association_Composition
{
    internal class Order
    {
        public int Id { get; set; }
        public string? BuyerEmail { get; set; }
        public string? SubTotel { get; set; }
        public OrderItem[]Items { get; set; } //relation is mandatory
        public Order(string BuyerEmail, OrderItem[] items)
        {
            this.BuyerEmail = BuyerEmail;
            Items = items;

        }
    }
}
