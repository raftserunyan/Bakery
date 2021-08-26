using Bakery.Data.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bakery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IUnitOfWork _uow;
        public OrdersController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        [HttpGet("Get")]
        public async Task<IActionResult> GetOrders()
        {
            return Ok();
        }

        [HttpGet("Get/{id}")]
        public async Task<IActionResult> GetOrder(int OrderId)
        {
            return Ok();
        }

        [HttpGet("GetOrdersByUserId/{userId}")]
        public async Task<IActionResult> GetOrdersByUserId(int UserId)
        {
            return Ok();
        }

        //admin
        [HttpPost()]
        public async Task<IActionResult> ChangeOrderStatus(int UserId) //???
        {
            return Ok();
        }
        
        [HttpGet("GetItems/{orderId}")]
        public async Task<IActionResult> GetItems(int OrderId)
        {
            return Ok();
        }

        [HttpGet("Cancel/{orderId}")]
        public async Task<IActionResult> CancelOrder(int OrderId)
        {
            return Ok();
        }
    }
}
