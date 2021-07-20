using System.Threading;
using System.Threading.Tasks;
using CCS.Application.Domains.Handlers;
using CCS.Application.Domains.Requests;
using Xunit;

namespace CCS.ApplicationTest.Domains.Handlers
{
    public class WeatherForecastHandlerTest
    {
        [Fact(DisplayName = "何らかのレスポンスがある")]
        public async Task Ok()
        {
            var request = new WeatherForecastRequest();
            var handler = new WeatherForecastHandler();
            var result = await handler.Handle(request, new CancellationToken());
            Assert.NotNull(result);
            Assert.True(result.Length > 0);
        }
    }
}
