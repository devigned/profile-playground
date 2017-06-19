using Azure.Mgmt.Models;
using System.Collections.Generic;
using System;

namespace Azure.Mgmt.Compute._2016_01_31.Models {
    public interface IVirtualMachine : IResource {
        string LicenseType { get; set; }
        IPlan Plan { get; set; }
        string ProvisioningState { get; }
    }
    public class VirtualMachine : Azure.Mgmt.Models.Resource, IVirtualMachine {

        public VirtualMachine(string name, string location, IDictionary<string, string> tags = null, string licenseType = null, IPlan plan = null) : base(name, location, tags){
            Plan = plan;
            LicenseType = licenseType;
        }

        /// <summary>
        /// Gets or sets specifies that the image or disk that is being used
        /// was licensed on-premises. This element is only used for images that
        /// contain the Windows Server operating system.
        /// </summary>
        public string LicenseType { get; set; }

        public IPlan Plan { get; set; }

        public string ProvisioningState {get; protected set;}
    }
}
