using MonolithWebApi.Domains.Entities;
using MediatR;

namespace MonolithWebApi.Domains.Requests
{
    /// <summary>
    /// WeatherForecast Request
    /// </summary>
    public class WeatherForecastRequest : IRequest<WeatherForecast[]>
    {
    }
}
