using Azure.Mgmt.Models;

namespace Azure.Mgmt.Compute._2016_06_30.Models {
    public class Disk : Azure.Mgmt.Compute.Models.Disk {
        /// <summary>
        /// Gets or sets if creationData.createOption is Empty, this field is
        /// mandatory and it indicates the size of the VHD to create. If this
        /// field is present for updates or creation with other options, it
        /// indicates a resize. Resizes are only allowed if the disk is not
        /// attached to a running VM, and can only increase the disk's size.
        /// </summary>
        public int? DiskSizeGB { get; set; }

        /// <summary>
        /// Gets a relative URI containing the VM id that has the disk
        /// attached.
        /// </summary>
        public string OwnerId { get; protected set; }
    }
}