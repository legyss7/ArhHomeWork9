
using MyFirstWebApplication.Models;

namespace MyFirstWebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //WeatherForecast weatherForecast = new WeatherForecast();
            //weatherForecast.TemperatureC = 23;
            //weatherForecast.

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddSingleton<WeatherForecastHolder>();


            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
