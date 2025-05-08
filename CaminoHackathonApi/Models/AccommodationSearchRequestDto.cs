using System.Collections.Generic;

namespace CaminoHackathonApi.Models
{
    public class AccommodationSearchRequestDto
    {
        public string WalletAddress { get; set; }
        public string Market { get; set; }
        public string Language { get; set; }
        public string Currency { get; set; }
        public List<QueryDto> Queries { get; set; } = new();
    }

    public class QueryDto
    {
        public string QueryId { get; set; }
        public DateDto CheckIn { get; set; }
        public DateDto CheckOut { get; set; }
        public List<TravellerDto> Travellers { get; set; } = new();
        public GeoCircleDto GeoCircle { get; set; }
    }

    public class DateDto
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }

    public class TravellerDto
    {
        public string TravellerId { get; set; }
        public string Type { get; set; }
        public DateDto Birthdate { get; set; }
        public string Nationality { get; set; }
    }

    public class GeoCircleDto
    {
        public CoordinateDto Center { get; set; }
        public LengthDto Radius { get; set; }
    }

    public class CoordinateDto
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }

    public class LengthDto
    {
        public double Value { get; set; }
        public string Unit { get; set; } // e.g. "LENGTH_UNIT_KILOMETER"
    }
}