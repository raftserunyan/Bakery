using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class IdentityController : ControllerBase 
	{
		[HttpPost("RegisterUser")]
		public async Task<IActionResult> RegisterUser()
		{
			return Ok();
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> LogIn(int id)
		{
			return "value";
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
