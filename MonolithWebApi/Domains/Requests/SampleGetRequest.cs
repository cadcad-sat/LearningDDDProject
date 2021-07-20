using System;
using MonolithWebApi.Domains.Entities;
using MediatR;

namespace MonolithWebApi.Domains.Requests
{
    /// <summary>
    /// Get Sample Request
    /// </summary>
    public class SampleGetRequest : IRequest<Sample>
    {
        public Guid Id { get; set; }
    }
}
