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

		// POST api/<IdentiryController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<IdentiryController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<IdentiryController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
