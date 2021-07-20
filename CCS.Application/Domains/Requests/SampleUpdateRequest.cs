using System;
using CCS.Application.Domains.Entities;
using MediatR;

namespace CCS.Application.Domains.Requests
{
    /// <summary>
    /// Update Sample Request
    /// </summary>
    public class SampleUpdateRequest : IRequest<Sample>
    {
        public Guid Id { get; set; }
    }
}
