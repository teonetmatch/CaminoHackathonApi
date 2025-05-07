using CaminoHackathonApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CaminoHackathonApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class PingController(IPingService pingService) : ControllerBase
	{
		public IPingService _pingService { get; set; } = pingService;

		[HttpGet(Name = "GetWeatherForecast")]
		public async Task<ActionResult<string>> Ping([FromHeader] string recipient)
		{
			var result = await _pingService.PingAsync(recipient);
			return result ? Ok("Ping works") : BadRequest();
		}
	}
}
