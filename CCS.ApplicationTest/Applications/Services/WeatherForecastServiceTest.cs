using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CCS.Application.Applications;
using CCS.Application.Domains.Entities;
using CCS.Application.Domains.Interfaces;
using CCS.Application.Domains.Requests;
using MediatR;
using Moq;
using Xunit;

namespace CCS.ApplicationTest.Applications.Services
{
    public class WeatherForecastServiceTest
    {
        [Fact(DisplayName = "取得できる")]
        public async Task List_Ok()
        {
            var now = DateTime.UtcNow;
            var repo = new Mock<IDbRepository>();
            var mediator = new Mock<IMediator>();
            mediator.Setup(x => x.Send(It.IsAny<WeatherForecastRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync(new List<WeatherForecast>
                {
                    new WeatherForecast{ Date = now, Summary = "Too Hot", TemperatureC = 35 },
                    new WeatherForecast{ Date = now.AddDays(-1), Summary = "Hot", TemperatureC = 30 },
                }.ToArray());
            var service = new WeatherForecastService(mediator.Object, repo.Object);
            var result = await service.List();
            Assert.NotNull(result);
            Assert.Equal(2, result.Length);
        }
    }
}
