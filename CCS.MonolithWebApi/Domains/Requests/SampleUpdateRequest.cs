using System;
using CCS.MonolithWebApi.Domains.Entities;
using MediatR;

namespace CCS.MonolithWebApi.Domains.Requests
{
    /// <summary>
    /// Update Sample Request
    /// </summary>
    public class SampleUpdateRequest : IRequest<Sample>
    {
        public Guid Id { get; set; }
    }
}
