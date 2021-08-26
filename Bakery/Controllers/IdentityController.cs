using System.Threading.Tasks;
using Bakery.Data.UnitOfWork;
using Bakery.Model;
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
		public async Task<IActionResult> RegisterUser(RegisterViewModel registerVM)
		{
			return Ok();
		}

		[HttpPost("SignIn")]
		public async Task<IActionResult> SignIn(SignInViewModel signInVM)
		{
			return Ok();
		}

		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
