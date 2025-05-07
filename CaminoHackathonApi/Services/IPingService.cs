namespace CaminoHackathonApi.Services
{
	public interface IPingService
	{
		Task<bool> PingAsync(string recipient);
	}
}
