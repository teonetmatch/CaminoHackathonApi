using CaminoHackathonApi.Models;
using CaminoHackathonApi.Services;
using Cmp.Services.Accommodation.V1;
using Microsoft.AspNetCore.Mvc;

namespace CaminoHackathonApi.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class EventsController(IAccommodationSearchService searchService) : ControllerBase
	{
		private readonly IAccommodationSearchService _searchSvc = searchService;

		[HttpPost]
		public async Task<ActionResult<AccommodationSearchResponse>> ReceiveEventAsync([FromBody] Event eventReceived)
		{
			var message = $"Event received: {eventReceived.EventType} - {eventReceived.Name} at {eventReceived.StartsAt}";
			Console.WriteLine(message);

			_ = Task.Run(async() =>
			{
				Console.WriteLine("Searching for hotels...");

				var result = await _searchSvc.SearchAsync(new AccommodationSearchRequestDto
				{
					StartDate = eventReceived.StartsAt,
					EndDate = eventReceived.EndsAt,
					Latitude = eventReceived.Latitude,
					Longitude = eventReceived.Longitude
				});

				Console.WriteLine($"Found {result.Results.Count}");
			});

			return Ok();
		}
	}
}
