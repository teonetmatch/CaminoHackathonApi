using System.Text.Json.Serialization;

namespace CaminoHackathonApi.Models
{
	public class TravellerNotification
	{
		public NotificationEvent Event { get; set; }
		[JsonPropertyName("results_page_url")]
		public string ResultsPageUrl { get; set; }
	}

	public class NotificationEvent
	{
		public string Name { get; set; }
		[JsonPropertyName("event_type")]
		public string EventType { get; set; }
		[JsonPropertyName("starts_at")]
		public DateTime StartsAt { get; set; }
		[JsonPropertyName("ends_at")]
		public DateTime EndsAt { get; set; }
		[JsonPropertyName("address")]
		public string Address { get; set; }
	}
}
