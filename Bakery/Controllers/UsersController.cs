using System.Threading.Tasks;
using Bakery.Data.UnitOfWork;
using Bakery.Model;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly IUnitOfWork _uow;

		public UsersController(IUnitOfWork uow)
		{
			_uow = uow;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			return Ok();
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> Get(int id)
		{
			return Ok();
		}


		[HttpPost("Register")]
		public async Task<IActionResult> Register([FromBody] RegisterDto registerVM)
		{
			return Ok();
		}

		[HttpPost("SignIn")]
		public async Task<IActionResult> SignIn([FromBody] SignInDto signInVM)
		{
			return await Task.FromResult(Ok());
		}


		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(int id)
		{
			return Ok();
		}


		[HttpPatch("{Id}/ResetPassword")]
		public async Task<IActionResult> ResetPassword(int Id, [FromBody] ResetPwdDto resetPwdVM)
		{
			return Ok();
		}

		[HttpPatch("{Id}/Edit")]
		public async Task<IActionResult> EditUser([FromBody] EditUserDto editUserVM)
		{
			return Ok();
		}
	}
}
