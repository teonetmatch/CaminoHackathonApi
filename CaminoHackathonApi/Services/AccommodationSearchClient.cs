using System;
using System.Threading.Tasks;
using Cmp.Services.Accommodation.V2;
using Cmp.Types.V1;
using Cmp.Types.V2;
using CaminoHackathonApi.Models;
using Grpc.Net.Client;
using Grpc.Core;

// The generated gRPC stubs for v2 accommodation
using AccomV2 = Cmp.Services.Accommodation.V2;
using AccomTypesV2 = Cmp.Services.Accommodation.V2;

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
                        EndUserWalletAddress = dto.WalletAddress,
                        Version = new Cmp.Types.V1.Version { Major = 1, Minor = 0, Patch = 0 }
                    }
                },
                SearchParametersGeneric = new Cmp.Types.V2.SearchParameters
                {
                    Currency = new Cmp.Types.V2.Currency { IsoCurrency = dto.Currency }
                }
            };


            foreach (var q in dto.Queries)
            {
                var query = new AccommodationSearchQuery
                {
                    QueryId = q.QueryId
                };

                // travel period
                query.TravelPeriods.Add(new TravelPeriod
                {
                    CheckIn = new Cmp.Types.V1.Date { Day = q.CheckIn.Day, Month = q.CheckIn.Month, Year = q.CheckIn.Year },
                    CheckOut = new Cmp.Types.V1.Date { Day = q.CheckOut.Day, Month = q.CheckOut.Month, Year = q.CheckOut.Year }
                });

                // travellers
                foreach (var t in q.Travellers)
                {
                    query.Travellers.Add(new BasicTraveller
                    {
                        TravellerId = t.TravellerId,
                        // nested enum is BasicTraveller.TravellerType
                        Type = Enum.Parse<Cmp.Types.V2.BasicTraveller.TravellerType>(t.Type, ignoreCase: true),
                        Birthdate = new Date
                        {
                            Day = t.Birthdate.Day,
                            Month = t.Birthdate.Month,
                            Year = t.Birthdate.Year
                        },
                        // expects Country enum
                        Nationality = (Cmp.Types.V1.Country)Enum.Parse<Cmp.Types.V1.Country>(t.Nationality, ignoreCase: true)
                    });
                }

                // optional geo-circle filter
                if (q.GeoCircle != null)
                {
                    query.SearchParametersAccommodation = new AccommodationSearchParameters
                    {
                        LocationGeoCircle = new Cmp.Types.V2.GeoCircle
                        {
                            Center = new Cmp.Types.V2.Coordinates
                            {
                                Latitude = q.GeoCircle.Center.Latitude,
                                Longitude = q.GeoCircle.Center.Longitude
                            },
                            Radius = new Length
                            {
                                // Length.Value is an int32
                                Value = Convert.ToInt32(q.GeoCircle.Radius.Value),
                                Unit = Enum.Parse<LengthUnit>(q.GeoCircle.Radius.Unit, ignoreCase: true)
                            }
                        }
                    };
                }


                req.Queries.Add(query);
            }

            // call the async RPC and return response
            var call = _grpc.AccommodationSearchAsync(req,metadata);
            return await call.ResponseAsync;
        }
    }
}
