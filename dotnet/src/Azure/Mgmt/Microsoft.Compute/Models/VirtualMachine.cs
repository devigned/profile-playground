using Azure.Mgmt.Models;

namespace Azure.Mgmt.Compute.Models
{
    public partial class VirtualMachine : Resource
    {
        /// <summary>
        /// Gets the disk provisioning state.
        /// </summary>
        public string ProvisioningState { get; protected set; }

        public Plan Plan { get; set; }
    }
}