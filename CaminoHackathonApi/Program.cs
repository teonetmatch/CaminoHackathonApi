
using CaminoHackathonApi.DependencyInjection;

namespace CaminoHackathonApi
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			builder.WebHost.ConfigureKestrel(options =>
			{
				options.ListenAnyIP(args.Length > 0 ? int.Parse(args[0]) : 5108);
			});

			// Add services to the container.

			builder.Services.AddControllers();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

            //Inject generated services
            builder.Services.AddServices();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
