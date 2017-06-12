using Azure.Mgmt.Models;
using Azure.Mgmt.Compute.Models;
using System.Collections.Generic;
using System;

namespace Azure.Mgmt.Compute._2016_06_30.Models {

    public interface IDisk : Azure.Mgmt.Compute.Models.IDisk {
        int? DiskSizeGB { get; set; }
        string OwnerId { get; set; }
    }

    public class Disk : Azure.Mgmt.Models.Resource, IDisk{
        public Disk(string name, string location, IDictionary<string, string> tags = null, int? diskSizeGB = null, string ownerId = null) : base(name, location, tags){
            DiskSizeGB = diskSizeGB;
            OwnerId = ownerId;
        }
        
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
        public string OwnerId { get; set; }

        public string ProvisioningState {get;}
    }
}