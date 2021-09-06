using System.Threading.Tasks;
using Bakery.Data.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CartController : ControllerBase
	{
		private readonly IUnitOfWork _uow;

		public CartController(IUnitOfWork uow)
		{
			_uow = uow;
		}

		[HttpGet("/Users/{userId}/Cart")]
		public async Task<IActionResult> GetCart(int userId)
		{
			return Ok();
		}

		[HttpGet("/Users/{userId}/Cart/{cartItemId}")]
		public async Task<IActionResult> GetCartItem(int userId, int cartItemId)
		{
			return Ok();
		}


		[HttpPost("/Users/{userId}/Cart")]
		public async Task<IActionResult> AddToCart(int userId)
		{
			return Ok();
		}


		[HttpPut("/Users/{userId}/Cart/{cartItemId}")]
		public async Task<IActionResult> UpdateCartItem(int userId, int cartItemId)
		{
			return Ok();
		}


		[HttpDelete("/Users/{userId}/Cart/{cartItemId}")]
		public async Task<IActionResult> DeleteCartItem(int userId, int cartItemId)
		{
			return Ok();
		}
	}
}
