using Azure.Mgmt.Models;

namespace Azure.Mgmt.Compute.Models {
    public class Disk : Resource {
        public string BaseDiskProperty { get; set; }
    }
}