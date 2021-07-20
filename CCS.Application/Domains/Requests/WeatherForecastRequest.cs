using CCS.Application.Domains.Entities;
using MediatR;

namespace CCS.Application.Domains.Requests
{
    /// <summary>
    /// WeatherForecast Request
    /// </summary>
    public class WeatherForecastRequest : IRequest<WeatherForecast[]>
    {
    }
}
