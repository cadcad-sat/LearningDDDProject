using System.Threading.Tasks;
using CCS.Application.Domains.Entities;
using CCS.Application.Domains.Interfaces;
using CCS.Application.Domains.Requests;
using MediatR;

namespace CCS.Application.Applications
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
