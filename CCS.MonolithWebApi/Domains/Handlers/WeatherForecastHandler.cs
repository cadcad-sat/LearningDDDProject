using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCS.MonolithWebApi.Domains.Entities;
using CCS.MonolithWebApi.Domains.Requests;
using MediatR;

namespace CCS.MonolithWebApi.Domains.Handlers
{
    /// <summary>
    /// WeatherForecastHandler
    /// </summary>
    public class WeatherForecastHandler : IRequestHandler<WeatherForecastRequest, WeatherForecast[]>
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        /// <summary>
        /// constructor
        /// </summary>
        public WeatherForecastHandler()
        {
        }

        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="request">SampleGetRequest</param>
        /// <param name="cancellation">CancellationToken</param>
        /// <returns>Sample</returns>
        public async Task<WeatherForecast[]> Handle(WeatherForecastRequest request, CancellationToken cancellation)
        {
            await Task.Delay(0);
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
