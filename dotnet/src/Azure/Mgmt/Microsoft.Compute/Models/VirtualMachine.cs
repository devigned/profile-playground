using System.Collections.Generic;
using Azure.Mgmt.Models;

namespace Azure.Mgmt.Compute.Models
{
    public interface IVirtualMachine: IResource {
        string ProvisioningState { get; }
    }
}