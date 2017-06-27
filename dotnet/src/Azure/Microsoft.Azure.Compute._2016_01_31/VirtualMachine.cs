using System.Collections.Generic;

namespace Microsoft.Azure.Compute
{
    public abstract partial class _2016_01_31
    {
        public class VirtualMachine : Resource
        {
            public VirtualMachine(
                string id,
                string name,
                string type,
                string location,
                IDictionary<string, string> tags = null,
                string licenseType = null, 
                Plan plan = null) : 
                base(id, name, type, location, tags)
            {
                Plan = plan;
                LicenseType = licenseType;
            }

            /// <summary>
            /// Gets or sets specifies that the image or disk that is being used
            /// was licensed on-premises. This element is only used for images that
            /// contain the Windows Server operating system.
            /// </summary>
            public string LicenseType { get; }

            public Plan Plan { get; }

            public string ProvisioningState { get; }
        }
    }
}
