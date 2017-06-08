using Azure.Mgmt.Models;
using Azure.Mgmt.Compute._2016_01_31.Models;

namespace Azure.Mgmt.Compute._2016_01_31.Operations {
    public class VirtualMachinesOperations {
        internal VirtualMachinesOperations(AzureClient client){

        }

        public VirtualMachine Create(string licenseType, Plan plan){
            return new VirtualMachine{ 
                Plan = plan,
                LicenseType = licenseType
            };
        }
    }
}