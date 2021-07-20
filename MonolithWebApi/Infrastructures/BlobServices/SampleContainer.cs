using MonolithWebApi.Domains.Entities;
using Microsoft.Extensions.Configuration;

namespace MonolithWebApi.Infrastructures.BlobServices
{
    public class SampleContainer : BaseContainer<Sample>
    {
        public SampleContainer(IConfiguration config)
            : base(config.GetConnectionString("StorageAccount"))
        {
        }
    }
}
