using Azure.Mgmt.Models;
using Azure.Mgmt.Compute._2016_06_30.Models;

namespace Azure.Mgmt.Compute._2016_06_30.Operations {
    public class VirtualMachinesOperations {
        internal VirtualMachinesOperations(AzureClient client){

        }

        public VirtualMachine Create(string licenseType, string vmId, Plan plan){
            return new VirtualMachine{ 
                Plan = plan,
                LicenseType = licenseType,
                VmId = vmId
            };
        }
    }
}