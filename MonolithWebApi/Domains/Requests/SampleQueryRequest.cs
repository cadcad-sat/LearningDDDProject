using System;
using MonolithWebApi.Domains.Entities;
using MediatR;

namespace MonolithWebApi.Domains.Requests
{
    /// <summary>
    /// Query Sample Request
    /// </summary>
    public class SampleQueryRequest : IRequest<Sample[]>
    {
        public Guid Id { get; set; }
    }
}
