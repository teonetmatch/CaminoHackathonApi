using CaminoHackathonApi.Services;
using Grpc.Net.Client;
using static Cmp.Services.Ping.V1.PingService;
using Cmp.Services.Accommodation.V2;

namespace CaminoHackathonApi.DependencyInjection
{
	public static class ServicesDIHelper
	{
		public static IServiceCollection AddServices(this IServiceCollection services)
		{
			services.AddScoped<IPingService>(provider =>
			{
				var channel = GrpcChannel.ForAddress("http://localhost:9090");
				return new PingService(new PingServiceClient(channel));
			});

            services.AddScoped<IAccommodationSearchService>(sp =>
            {
                var channel = GrpcChannel.ForAddress("http://localhost:9090");
                return new AccommodationSearchClient(channel);
            });

            return services;
		}
	}
}
