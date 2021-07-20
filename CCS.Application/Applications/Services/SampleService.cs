using System;
using System.Threading.Tasks;
using CCS.Application.Domains.Entities;
using CCS.Application.Domains.Interfaces;
using CCS.Application.Domains.Requests;
using MediatR;

namespace CCS.Application.Applications
{
    public class SampleService : BaseService
    {
        public SampleService(IMediator mediator, IDbRepository dbRepository)
            : base(mediator, dbRepository)
        {
        }

        public async Task<Sample> GetById(Guid id)
        {
            return await _mediator.Send(new SampleGetRequest { Id = id });
        }

        public async Task<Sample> Create()
        {
            var result = await _mediator.Send(new SampleInsertRequest());
            _dbRepository.Commit();
            return await _mediator.Send(new SampleGetRequest { Id = result.Id });
        }

        public async Task<Sample[]> Search()
        {
            return await _mediator.Send(new SampleQueryRequest { });
        }

        public async Task<Sample> Update(Guid id)
        {
            await _mediator.Send(new SampleGetRequest { Id = id });
            _dbRepository.Commit();
            return await _mediator.Send(new SampleGetRequest { Id = id });
        }
    }
}
