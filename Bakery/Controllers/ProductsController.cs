using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bakery.Data.Interfaces;
using Bakery.Data.Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		private readonly IProductRepository _productRepo;

		public ProductsController(IProductRepository productRepo)
		{
			_productRepo = productRepo;
		}


		// GET: api/<ProductsController>
		[HttpGet]
		public async Task<IEnumerable<Product>> Get()
		{
			return await _productRepo.GetAll();
		}

		// GET api/<ProductsController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<ProductsController>
		[HttpPost]
		public async Task Post([FromBody] Product value)
		{
			await _productRepo.Add(value);
		}

		// PUT api/<ProductsController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<ProductsController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
