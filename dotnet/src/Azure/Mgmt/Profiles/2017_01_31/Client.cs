using System.Collections.Generic;
using _2016_01_31 = Azure.Mgmt.Compute._2016_01_31;
using _2016_06_30 = Azure.Mgmt.Compute._2016_06_30;

namespace Azure.Mgmt.Profiles._2017_01_31
{
    namespace Models {
        public class Factories
        {
            public _2016_01_31.Models.IVirtualMachine VirtualMachine(string name, string location, IDictionary<string, string> tags = null, string licenseType = null, string vmId = null, _2016_01_31.Models.IPlan plan = null)
            {
                return new _2016_01_31.Models.VirtualMachine(name, location, tags, licenseType, plan);
            }

            public _2016_01_31.Models.IPlan Plan(string name, string publisher = default(string), string promotionCode = default(string))
            {
                return new _2016_01_31.Models.Plan(name, promotionCode, publisher);
            }

            public _2016_06_30.Models.IDisk Disk(string name, string location, IDictionary<string, string> tags = null, int? diskSizeGB = default(int?), string ownerId = default(string))
            {
                return new _2016_06_30.Models.Disk(name, location, tags, diskSizeGB, ownerId);
            }
        }
    }
    public class Compute
    {
        internal Compute(AzureClient client)
        {
            VirtualMachines = new _2016_01_31.Operations.VirtualMachinesOperations(client);
            Disks = new _2016_06_30.Operations.DisksOperations(client);
            Models = new Models.Factories();
        }
        public _2016_01_31.Operations.VirtualMachinesOperations VirtualMachines { get; protected set; }
        public _2016_06_30.Operations.DisksOperations Disks { get; protected set; }

        public Models.Factories Models { get; protected set; }

    }

    public class Client : AzureClient
    {
        public Client()
        {
            Compute = new Compute(this);
        }

        public Compute Compute { get; protected set; }
    }
}