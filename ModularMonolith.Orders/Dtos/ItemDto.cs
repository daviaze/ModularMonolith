using ModularMonolith.Orders.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolith.Orders.Dtos
{
    public sealed record ItemDto
    {
        [Required(ErrorMessage = "The field ProductId is required")]
        public Guid ProductId { get; set; }

        [Required(ErrorMessage = "The field Quantity is required")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "The field Price is required")]
        public decimal Price { get; set; }
    }
}
