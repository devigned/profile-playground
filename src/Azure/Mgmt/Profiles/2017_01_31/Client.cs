using _2016_01_31=Azure.Mgmt.Compute._2016_01_31.Operations;
using _2016_06_30=Azure.Mgmt.Compute._2016_06_30.Operations;

namespace Azure.Mgmt.Profiles._2017_01_31 {
    public class Compute {
        internal Compute(AzureClient client) {
            VirtualMachines = new _2016_01_31.VirtualMachinesOperations(client);
            Disks = new _2016_06_30.DisksOperations(client);
        }
        public _2016_01_31.VirtualMachinesOperations VirtualMachines { get; protected set;}
        public _2016_06_30.DisksOperations Disks { get; protected set; }

    }
    public class Client : AzureClient {
        public Client(){
            Compute = new Compute(this);
        }

        public Compute Compute { get; protected set;}
    }
}