using System;
using CCS.Application.Domains.Entities;
using MediatR;

namespace CCS.Application.Domains.Requests
{
    /// <summary>
    /// Query Sample Request
    /// </summary>
    public class SampleQueryRequest : IRequest<Sample[]>
    {
        public Guid Id { get; set; }
    }
}
