using CCS.MonolithWebApi.Domains.Entities;
using MediatR;

namespace CCS.MonolithWebApi.Domains.Requests
{
    /// <summary>
    /// WeatherForecast Request
    /// </summary>
    public class WeatherForecastRequest : IRequest<WeatherForecast[]>
    {
    }
}
