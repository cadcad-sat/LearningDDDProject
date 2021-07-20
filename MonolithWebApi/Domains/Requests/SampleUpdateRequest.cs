using System;
using MonolithWebApi.Domains.Entities;
using MediatR;

namespace MonolithWebApi.Domains.Requests
{
    /// <summary>
    /// Update Sample Request
    /// </summary>
    public class SampleUpdateRequest : IRequest<Sample>
    {
        public Guid Id { get; set; }
    }
}
