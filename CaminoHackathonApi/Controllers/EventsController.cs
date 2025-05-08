using System.Text.Json;
using System.Text;
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

				//var result = await _searchSvc.SearchAsync(new AccommodationSearchRequestDto
				//{
				//	StartDate = eventReceived.StartsAt,
				//	EndDate = eventReceived.EndsAt,
				//	Latitude = eventReceived.Latitude,
				//	Longitude = eventReceived.Longitude
				//});

				Console.WriteLine("Hotels retrieved successfully");

				using var httpClient = new HttpClient();
				var jsonBody = JsonSerializer.Serialize(new TravellerNotification
				{
					Event = new NotificationEvent
					{
						Name = eventReceived.Name,
						EventType = eventReceived.EventType,
						StartsAt = eventReceived.StartsAt,
						EndsAt = eventReceived.EndsAt,
						Address = eventReceived.Address
					},
					ResultsPageUrl = "https://example.com"
				});
				var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

				var response = await httpClient.PostAsync("https://events-service-voja.onrender.com/notify_travellers", content);

				if (response.IsSuccessStatusCode)
				{
					Console.WriteLine("Event notification sent successfully.");
				}
				else
				{
					Console.WriteLine($"Failed to send event notification. Status Code: {response.StatusCode}");
				}

			});

			return Ok();
		}
	}
}
