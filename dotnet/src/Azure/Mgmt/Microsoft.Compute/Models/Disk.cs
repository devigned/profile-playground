using System.Collections.Generic;
using Azure.Mgmt.Models;

namespace Azure.Mgmt.Compute.Models {
    public interface IDisk : IResource {
        string ProvisioningState {get;}
    }
}