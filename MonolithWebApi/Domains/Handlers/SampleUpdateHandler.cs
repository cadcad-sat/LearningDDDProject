using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MonolithWebApi.Domains.Entities;
using MonolithWebApi.Domains.Interfaces;
using MonolithWebApi.Domains.Requests;
using MediatR;

namespace MonolithWebApi.Domains.Handlers
{
    /// <summary>
    /// Update Sample
    /// </summary>
    public class SampleUpdateHandler : IRequestHandler<SampleUpdateRequest, Sample>
    {
        private readonly IDbRepository _dbRepository;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="dbRepository">IDbRepository</param>
        public SampleUpdateHandler(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }

        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="request">SampleUpdateRequest</param>
        /// <param name="cancellation">CancellationToken</param>
        /// <returns>Sample</returns>
        public Task<Sample> Handle(SampleUpdateRequest request, CancellationToken cancellation)
        {
            var entiry = _dbRepository.GetQuery<Sample>()
                .FirstOrDefault(x => x.Id == request.Id);

            return Task.FromResult(entiry);
        }
    }
}
