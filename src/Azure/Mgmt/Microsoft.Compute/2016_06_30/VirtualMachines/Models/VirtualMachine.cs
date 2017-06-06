using Azure.Mgmt.Models;

namespace Azure.Mgmt.Compute._2016_06_30.Models
{
    public class VirtualMachine : Azure.Mgmt.Compute._2016_01_31.Models.VirtualMachine
    {
        /// <summary>
        /// Gets specifies the VM unique ID which is a 128-bits identifier that
        /// is encoded and stored in all Azure IaaS VMs SMBIOS and can be read
        /// using platform BIOS commands.
        /// </summary>
        public string VmId { get; protected set; }
    }
}