using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CCS.Application.Domains.Entities;
using CCS.Application.Domains.Interfaces;
using CCS.Application.Domains.Requests;
using MediatR;

namespace CCS.Application.Domains.Handlers
{
    /// <summary>
    /// Query Sample
    /// </summary>
    public class SampleQueryHandler : IRequestHandler<SampleQueryRequest, Sample[]>
    {
        private readonly IDbRepository _dbRepository;

        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="dbRepository">IDbRepository</param>
        public SampleQueryHandler(IDbRepository dbRepository)
        {
            _dbRepository = dbRepository;
        }

        /// <summary>
        /// Handle
        /// </summary>
        /// <param name="request">SampleQueryRequest</param>
        /// <param name="cancellation">CancellationToken</param>
        /// <returns>Sample</returns>
        public Task<Sample[]> Handle(SampleQueryRequest request, CancellationToken cancellation)
        {
            var response = _dbRepository.GetQuery<Sample>();
            return Task.FromResult(response.ToArray());
        }
    }
}
