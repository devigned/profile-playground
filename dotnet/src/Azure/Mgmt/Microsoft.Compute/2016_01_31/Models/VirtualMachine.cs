using Azure.Mgmt.Models;

namespace Azure.Mgmt.Compute._2016_01_31.Models {
    public class VirtualMachine : Azure.Mgmt.Compute.Models.VirtualMachine {
        /// <summary>
        /// Gets or sets specifies that the image or disk that is being used
        /// was licensed on-premises. This element is only used for images that
        /// contain the Windows Server operating system.
        /// </summary>
        public string LicenseType { get; set; }

        public new Plan Plan { get; set; }
    }
}
