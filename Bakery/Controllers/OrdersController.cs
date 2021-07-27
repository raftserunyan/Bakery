using System.Collections.Generic;
using System.Threading.Tasks;
using Bakery.Data.Interfaces;
using Bakery.Data.Model.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Microsoft.AspNetCore.Identity;

namespace Bakery.Controllers 
{
	[Route("api/[controller]")]
	[ApiController]
	public class OrdersController : IdentityUser
	{
		
		private readonly IOrderRepository _orderRepo;
		public OrdersController(IOrderRepository orderRepo)
		{
			_orderRepo = orderRepo;
		}

		[HttpGet]
		public async Task<IEnumerable<Order>> Get()
		{
			return await _orderRepo.GetAll();
		}

		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<OrdersController>
		[HttpPost]
		public async Task Post(Order order)
		{
			await _orderRepo.Add(order);
		}

		// PUT api/<OrdersController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<OrdersController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
