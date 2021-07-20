using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCS.Application.Domains.Entities;
using CCS.Application.Domains.Handlers;
using CCS.Application.Domains.Interfaces;
using CCS.Application.Domains.Requests;
using Moq;
using Xunit;

namespace CCS.ApplicationTest.Domains.Handlers
{
    public class SampleGetHandlerTest
    {
        [Fact(DisplayName = "取得できる")]
        public async Task Ok()
        {
            var id = Guid.NewGuid();
            var now = DateTimeOffset.UtcNow;
            var entity1 = new Sample
            {
                Id = id,
                CreateDateTime = now,
                UpdateDateTime = now
            };
            var entity2 = new Sample
            {
                Id = Guid.NewGuid(),
                CreateDateTime = now,
                UpdateDateTime = now
            };
            var repo = new Mock<IDbRepository>();
            repo.Setup(x => x.GetQuery<Sample>())
                .Returns(new List<Sample>
                {
                    entity1,
                    entity2
                }.AsQueryable());
            var request = new SampleGetRequest { Id = id };
            var handler = new SampleGetHandler(repo.Object);
            var result = await handler.Handle(request, new CancellationToken());
            Assert.NotNull(result);
            Assert.Equal(id, result.Id);
        }

        [Fact(DisplayName = "取得できない")]
        public async Task Null()
        {
            var id = Guid.NewGuid();
            var now = DateTimeOffset.UtcNow;
            var entity1 = new Sample
            {
                Id = Guid.NewGuid(),
                CreateDateTime = now,
                UpdateDateTime = now
            };
            var entity2 = new Sample
            {
                Id = Guid.NewGuid(),
                CreateDateTime = now,
                UpdateDateTime = now
            };
            var repo = new Mock<IDbRepository>();
            repo.Setup(x => x.GetQuery<Sample>())
                .Returns(new List<Sample>
                {
                    entity1,
                    entity2
                }.AsQueryable());
            var request = new SampleGetRequest { Id = id };
            var handler = new SampleGetHandler(repo.Object);
            var result = await handler.Handle(request, new CancellationToken());
            Assert.Null(result);
        }
    }
}
