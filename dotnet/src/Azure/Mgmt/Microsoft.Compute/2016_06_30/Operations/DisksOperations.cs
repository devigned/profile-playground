using Azure.Mgmt.Models;
using Azure.Mgmt.Compute._2016_06_30.Models;
using System.Collections.Generic;

namespace Azure.Mgmt.Compute._2016_06_30.Operations {
    public class DisksOperations {
        internal DisksOperations(AzureClient client){

        }

        public IDisk Create(string name, string location, IDictionary<string, string> tags = null, int? diskSizeGB = null, string ownerId = null){
            return new Disk(name, location, tags, diskSizeGB, ownerId);
        }
    }
}