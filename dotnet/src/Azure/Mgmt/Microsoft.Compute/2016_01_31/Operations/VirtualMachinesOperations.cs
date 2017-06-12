using Azure.Mgmt.Models;
using Azure.Mgmt.Compute._2016_01_31.Models;
using System.Collections.Generic;

namespace Azure.Mgmt.Compute._2016_01_31.Operations {
    public class VirtualMachinesOperations {
        public VirtualMachinesOperations(AzureClient client){

        }

        public IVirtualMachine Create(string name, string location, IDictionary<string, string> tags = null, string licenseType = null, IPlan plan=null){
            return new VirtualMachine(name, location, tags, licenseType, plan);
        }
    }
}