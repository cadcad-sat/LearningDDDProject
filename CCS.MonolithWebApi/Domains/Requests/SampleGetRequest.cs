using System;
using CCS.MonolithWebApi.Domains.Entities;
using MediatR;

namespace CCS.MonolithWebApi.Domains.Requests
{
    /// <summary>
    /// Get Sample Request
    /// </summary>
    public class SampleGetRequest : IRequest<Sample>
    {
        public Guid Id { get; set; }
    }
}
