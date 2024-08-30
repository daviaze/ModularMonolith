using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolith.Orders.Entities
{
    [Table("Item")]
    internal sealed class Item
    {
        [Required(ErrorMessage = "The field ProductId is required")]
        public Product ProductId { get; set; }

        [Required(ErrorMessage = "The field Quantity is required")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "The field Price is required")]
        public decimal Price { get; set; }

        public Order OrderId { get; set; }

    }
}
