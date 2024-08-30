using FluentResults;
using Microsoft.AspNetCore.Mvc;
using ModularMonolith.Orders.Dtos;
using ModularMonolith.Orders.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModularMonolith.Orders.Controllers
{
    [ApiController]
    [Route("orders")]
    public sealed class OrderController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok();
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetById(string id)
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> PostOrder([FromBody] OrderDto order)
        {
            return Ok();
        }
    }
}
