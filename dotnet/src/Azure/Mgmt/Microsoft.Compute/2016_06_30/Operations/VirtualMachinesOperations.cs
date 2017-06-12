using Azure.Mgmt.Models;
using Azure.Mgmt.Compute._2016_06_30.Models;
using System.Collections.Generic;

namespace Azure.Mgmt.Compute._2016_06_30.Operations {
    public class VirtualMachinesOperations {
        internal VirtualMachinesOperations(AzureClient client){

        }

        public IVirtualMachine Create(string name, string location, IDictionary<string, string> tags = null, string licenseType = null, string vmId = null, IPlan plan = null){
            return new VirtualMachine(name, location, tags, licenseType, vmId, plan);
        }
    }
}