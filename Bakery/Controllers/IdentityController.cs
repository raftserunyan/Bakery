using System.Threading.Tasks;
using Bakery.Data.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class IdentityController : ControllerBase 
	{
		private readonly IUnitOfWork _uow;

		public IdentityController(IUnitOfWork uow)
		{
			_uow = uow;
		}


		[HttpPost("RegisterUser")]
		public async Task<IActionResult> RegisterUser()
		{
			return Ok();
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> LogIn(int id)
		{
			return Ok();
		}
	}
}
