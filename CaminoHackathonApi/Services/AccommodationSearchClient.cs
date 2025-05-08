using CaminoHackathonApi.Models;
using Cmp.Services.Accommodation.V2;
using Cmp.Types.V1;
using Google.Protobuf.Collections;
using Grpc.Core;
using Grpc.Net.Client;
// The generated gRPC stubs for v2 accommodation
using AccomV2 = Cmp.Services.Accommodation.V2;
// v1 types for header and travel-period/date
using TypesV1 = Cmp.Types.V1;
// v2 types for currency, geo, coordinates
using TypesV2 = Cmp.Types.V2;

namespace CaminoHackathonApi.Services
{
    /// <summary>
    /// Implements IAccommodationSearchService by calling the generated gRPC stub.
    /// Renamed from “AccommodationSearchService” to avoid a name clash.
    /// </summary>
    public class AccommodationSearchClient : IAccommodationSearchService
    {
        private readonly AccommodationSearchService.AccommodationSearchServiceClient _grpc;

        public AccommodationSearchClient(GrpcChannel channel)
        {
            // This type comes from your one NuGet: BSR.Chain4travel.Camino-Messenger-Protocol.Grpc.CSharp
            _grpc = new AccommodationSearchService
                        .AccommodationSearchServiceClient(channel);
        }

        public async Task<AccommodationSearchResponse> SearchAsync(AccommodationSearchRequestDto dto)
        {

            var metadata = new Metadata
            {
                new Metadata.Entry("recipient", "0x0dcafe4433d932d605ba15d1787fa242e8151288")
            };

            var req = new AccomV2.AccommodationSearchRequest
            {
                Header = new RequestHeader
                {

                    BaseHeader = new Header
                    {
                        EndUserWalletAddress = "Excepteur dolore non",
                        Version = new Cmp.Types.V1.Version { Major = 1, Minor = 0, Patch = 0 }
                    }
                },
                SearchParametersGeneric = new Cmp.Types.V2.SearchParameters
                {
                    Currency = new Cmp.Types.V2.Currency { IsoCurrency =  new TypesV2.IsoCurrency() }
                }
            };


                var query = new AccommodationSearchQuery
                {
                    TravelPeriod = new TypesV1.TravelPeriod
                    {
                        StartDate = new Date
                        {
                            Day = dto.StartDate.Day,
                            Month = dto.StartDate.Month,
                            Year = dto.StartDate.Year,
                        },
                        EndDate = new Date
                        {
                            Day = dto.EndDate.Day,
                            Month = dto.EndDate.Month,
                            Year = dto.EndDate.Year,
                        },
                    },

                };
            Cmp.Types.V2.BasicTraveller basic = new Cmp.Types.V2.BasicTraveller
            {
                Birthdate = new Date
                {
                    Day = 1,
                    Month = 1,
                    Year = 1990
                }
            };
            query.Travellers.Add(basic);
            query.Travellers.Add(basic);

            query.SearchParametersAccommodation = new AccommodationSearchParameters
            {
                LocationGeoCircle = new Cmp.Types.V2.GeoCircle
                {
                    Center = new Cmp.Types.V2.Coordinates
                    {
                        Latitude = dto.Latitude,
                        Longitude = dto.Longitude,
                    },
                    Radius = new Length
                    {
                        Value = 5,
                        Unit = LengthUnit.Kilometer,
                    }
                }
            };


            req.Queries.Add(query);

            // call the async RPC and return response
            var call = _grpc.AccommodationSearchAsync(req,metadata);
            return await call.ResponseAsync;
        }
    }
}
