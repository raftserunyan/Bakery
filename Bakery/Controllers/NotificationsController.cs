using System.Threading.Tasks;
using Bakery.Model;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class NotificationsController : ControllerBase
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
		public async Task<IActionResult> AddNotification(NotificationDto notification)
		{
			return Ok();
		}

		[HttpPut]
		public async Task<IActionResult> UpdateNotification(NotificationDto notification)
		{
			return Ok();
		}

		[HttpDelete("id")]
		public async Task<IActionResult> DeleteNotification(int id)
		{
			return Ok();
		}




		[HttpGet("/Users/{userId}/Notifications")]
		public async Task<IActionResult> GetCart(int userId)
		{
			return Ok();
		}

		[HttpGet("/Users/{userId}/Notifications/{notificationId}")]
		public async Task<IActionResult> GetCartItem(int userId, int notificationId)
		{
			return Ok();
		}


		[HttpPost("/Users/{userId}/Notifications")]
		public async Task<IActionResult> AddToCart(int userId)
		{
			return Ok();
		}


		[HttpPut("/Users/{userId}/Notifications/{notificationId}")]
		public async Task<IActionResult> UpdateCartItem(int userId, int notificationId)
		{
			return Ok();
		}


		[HttpDelete("/Users/{userId}/Notifications/{notificationId}")]
		public async Task<IActionResult> DeleteCartItem(int userId, int notificationId)
		{
			return Ok();
		}
	}
}
