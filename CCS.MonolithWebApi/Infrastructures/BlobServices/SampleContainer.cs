using CCS.MonolithWebApi.Domains.Entities;
using Microsoft.Extensions.Configuration;

namespace CCS.MonolithWebApi.Infrastructures.BlobServices
{
    public class SampleContainer : BaseContainer<Sample>
    {
        public SampleContainer(IConfiguration config)
            : base(config.GetConnectionString("StorageAccount"))
        {
        }
    }
}
