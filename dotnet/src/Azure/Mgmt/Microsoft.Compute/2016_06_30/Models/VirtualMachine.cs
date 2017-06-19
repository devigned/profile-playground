using System;
using System.Collections.Generic;
using Azure.Mgmt.Compute._2016_01_31.Models;
using Azure.Mgmt.Models;

namespace Azure.Mgmt.Compute._2016_06_30.Models
{
    public interface IVirtualMachine : IResource {
        string VmId { get; set; }
        IPlan Plan {get; set; }
        string LicenseType { get; set; }
        string ProvisioningState { get; }
    }
    public class VirtualMachine : Azure.Mgmt.Models.Resource, IVirtualMachine
    {
        public VirtualMachine(string name, string location, IDictionary<string, string> tags = null, string licenseType = null, string vmId = null, IPlan plan = null) : base(name, location, tags)
        {
            VmId = vmId;
            LicenseType = licenseType;
            Plan = plan;
        }

        /// <summary>
        /// Gets specifies the VM unique ID which is a 128-bits identifier that
        /// is encoded and stored in all Azure IaaS VMs SMBIOS and can be read
        /// using platform BIOS commands.
        /// </summary>
        public string VmId { get; set; }

        public IPlan Plan { get; set; }
        public string LicenseType { get; set; }
        public string ProvisioningState {get;}
    }
}