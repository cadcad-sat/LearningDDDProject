using System.Threading.Tasks;
using CCS.MonolithWebApi.Domains.Entities;
using CCS.MonolithWebApi.Domains.Interfaces;
using CCS.MonolithWebApi.Domains.Requests;
using MediatR;

namespace CCS.MonolithWebApi.Applications
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
