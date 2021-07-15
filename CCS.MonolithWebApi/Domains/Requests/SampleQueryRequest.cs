using System;
using CCS.MonolithWebApi.Domains.Entities;
using MediatR;

namespace CCS.MonolithWebApi.Domains.Requests
{
    /// <summary>
    /// Query Sample Request
    /// </summary>
    public class SampleQueryRequest : IRequest<Sample[]>
    {
        public Guid Id { get; set; }
    }
}
