using CaminoHackathonApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CaminoHackathonApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class EventsController : ControllerBase
	{
		[HttpPost]
		public IActionResult ReceiveEvent([FromBody] Event eventReceived)
		{
			var message = $"Event received: {eventReceived.EventType} - {eventReceived.Name} at {eventReceived.StartsAt}";
			return Ok(message);
		}
	}
}
