using System;
using System.Threading;
using System.Threading.Tasks;
using MonolithWebApi.Domains.Entities;
using MonolithWebApi.Domains.Interfaces;
using MonolithWebApi.Domains.Requests;
using MediatR;

namespace MonolithWebApi.Domains.Handlers
{
    /// <summary>
    /// Insert Sample
    /// </summary>
    public class SampleInsertHandler : IRequestHandler<SampleInsertRequest, Sample>
    {
        private readonly IDbRepository _dbRepository;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="dbRepository">IDbRepository</param>
        public SampleInsertHandler(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }

        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="request">SampleInsertRequest</param>
        /// <param name="cancellation">CancellationToken</param>
        /// <returns>Sample</returns>
        public Task<Sample> Handle(SampleInsertRequest request, CancellationToken cancellation)
        {
            var now = DateTimeOffset.UtcNow;
            var entity = new Sample
            {
                Id = Guid.NewGuid(),
                CreateDateTime = now,
                UpdateDateTime = now
            };
            _dbRepository.Add(entity);
            return Task.FromResult(entity);
        }
    }
}
