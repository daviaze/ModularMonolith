using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolith.Orders.Entities
{
    [Table("Order")]
    internal class Order
    {
        [Key]
        public Guid Id { get; set; }

        public decimal Total { get; set; }

        public decimal Increase { get; set; }

        public decimal Discount { get; set; }

        public IEnumerable<Item> Items { get; set; } = Enumerable.Empty<Item>();
    }
}
