using CCS.Application.Domains.Entities;
using Microsoft.Extensions.Configuration;

namespace CCS.Application.Infrastructures.BlobServices
{
    public class SampleContainer : BaseContainer<Sample>
    {
        public SampleContainer(IConfiguration config)
            : base(config.GetConnectionString("StorageAccount"))
        {
        }
    }
}
