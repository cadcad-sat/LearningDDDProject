using System;
using CCS.Application.Domains.Entities;
using MediatR;

namespace CCS.Application.Domains.Requests
{
    /// <summary>
    /// Get Sample Request
    /// </summary>
    public class SampleGetRequest : IRequest<Sample>
    {
        public Guid Id { get; set; }
    }
}
