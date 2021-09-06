using System.Threading.Tasks;
using Bakery.Model;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			return Ok();
		}

		[HttpGet("id")]
		public async Task<IActionResult> Get(int id)
		{
			return Ok();
		}

		[HttpPost]
		public async Task<IActionResult> AddProduct(ProductDto product)
		{
			return Ok();
		}

		[HttpPut]
		public async Task<IActionResult> UpdateProduct(ProductDto product)
		{
			return Ok();
		}

		[HttpDelete("id")]
		public async Task<IActionResult> DeleteProduct(int id)
		{
			return Ok();
		}
	}
}
