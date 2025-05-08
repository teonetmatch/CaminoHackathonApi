namespace CaminoHackathonApi.Models
{
	public class Event
	{
		public int Id { get; set; }
		public string EventType { get; set; }
		public string Name { get; set; }
		public DateTime StartsAt { get; set; }
		public DateTime EndsAt { get; set; }
		public double Longitude { get; set; }
		public double Latitude { get; set; }
	}
}
