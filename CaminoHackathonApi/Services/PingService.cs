using Cmp.Services.Ping.V1;
using Grpc.Core;
using static Cmp.Services.Ping.V1.PingService;

namespace CaminoHackathonApi.Services
{
	public class PingService(PingServiceClient serviceClient) : IPingService
	{
		private readonly PingServiceClient _serviceClient = serviceClient;

		public async Task<bool> PingAsync(string recipient)
		{
			var metadata = new Metadata
			{
				new Metadata.Entry("recipient", recipient)
			};
			var request = new PingRequest
			{
				Header = new Cmp.Types.V1.RequestHeader { BaseHeader = new Cmp.Types.V1.Header { EndUserWalletAddress = "test" } },
				PingMessage = "Ping",
				Timestamp = new Google.Protobuf.WellKnownTypes.Timestamp()
			};
			var response = await _serviceClient.PingAsync(request, metadata);
			if (response?.Header.Status == Cmp.Types.V1.StatusType.Success)
			{
				return true;
			}
			return false;
		}
	}
}
