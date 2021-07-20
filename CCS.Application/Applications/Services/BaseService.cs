using CCS.Application.Domains.Interfaces;
using MediatR;

namespace CCS.Application.Applications
{
    public class BaseService
    {
        protected readonly IMediator _mediator;
        protected readonly IDbRepository _dbRepository;
        public BaseService(IMediator mediator, IDbRepository dbRepository)
        {
            _mediator = mediator;
            _dbRepository = dbRepository;
        }
    }
}
