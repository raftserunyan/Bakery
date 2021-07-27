using System.Collections.Generic;
using System.Threading.Tasks;
using Bakery.Data.Interfaces;
using Bakery.Data.Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomersController : ControllerBase
	{
		private readonly ICustomerRepository _customerRepo;
		public CustomersController(ICustomerRepository customerRepo)
		{
			_customerRepo = customerRepo;
		}

		// GET: api/<CustomersController>
		[HttpGet]
		public async Task<IEnumerable<Customer>> Get()
		{
			return await _customerRepo.GetAll();
		}

		// GET api/<CustomersController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<CustomersController>
		[HttpPost]
		public async Task Post(Customer customer)
		{
			await _customerRepo.Add(customer);
		}

		// PUT api/<CustomersController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<CustomersController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
