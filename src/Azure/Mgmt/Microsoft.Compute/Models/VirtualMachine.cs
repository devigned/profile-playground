using Azure.Mgmt.Models;

namespace Azure.Mgmt.Compute.Models
{
    public class VirtualMachine : Resource
    {
        public string BaseVMProperty { get; set; }
    }
}