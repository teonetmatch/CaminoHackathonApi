using System.Text.Json.Serialization;

namespace CaminoHackathonApi.Models
{
	public class Event
	{
		public int Id { get; set; }
		[JsonPropertyName("event_type")]
		public string EventType { get; set; }
		public string Name { get; set; }
		[JsonPropertyName("starts_at")]
		public DateTime StartsAt { get; set; }
		[JsonPropertyName("ends_at")]
		public DateTime EndsAt { get; set; }
		public double Longitude { get; set; }
		public double Latitude { get; set; }
	}
}
