using System.Threading.Tasks;
using MonolithWebApi.Domains.Entities;
using MonolithWebApi.Domains.Interfaces;
using MonolithWebApi.Domains.Requests;
using MediatR;

namespace MonolithWebApi.Applications
{
    public class WeatherForecastService : BaseService
    {
        public WeatherForecastService(IMediator mediator, IDbRepository dbRepository)
            : base(mediator, dbRepository)
        {
        }

        public async Task<WeatherForecast[]> List()
        {
            return await _mediator.Send(new WeatherForecastRequest());
        }
    }
}
