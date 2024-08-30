using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolith.Orders.Dtos
{
    public sealed record class OrderDto
    {

        [Required(ErrorMessage = "The field Total is required")]
        public decimal Total { get; set; }

        [Required(ErrorMessage = "The increase Total is required")]
        public decimal Increase { get; set; }

        [Required(ErrorMessage = "The field discount is required")]
        public decimal Discount { get; set; }

        [Required(ErrorMessage = "The field items is required")]
        public List<ItemDto> Items { get; set; } = new List<ItemDto>();
    }
}
