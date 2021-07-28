using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bakery.Model;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class IdentityController : ControllerBase
	{
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

		[HttpGet("logOut/{id}")]
		public async Task<IActionResult> LogOut(int id)
		{
			return Ok();
		}

		[HttpGet("GetUser/{id}")]
		public async Task<IActionResult> GetUserById(int userId)
		{
			return Ok();
		}

		[HttpPut("ChangePassword")]
		public async Task<IActionResult> ChangeUserPassword(UserViewModel userVM)
        {
			return Ok();
        }

		[HttpGet("ConfirmEmail/{id}")]
		public async Task<IActionResult> RequestEmailConfirmation(string mail)
		{
			return Ok();
		}

		[HttpPost("EmailConfirmed/{confirmationId}")]
		public async Task<IActionResult> EmailConfirmed(string confirmationId)
		{
			return Ok();
		}

		[HttpGet("ResetPassword/{username}")]
		public async Task<IActionResult> ResetPassword(string username)
		{
			return Ok();
		}









	}
}
