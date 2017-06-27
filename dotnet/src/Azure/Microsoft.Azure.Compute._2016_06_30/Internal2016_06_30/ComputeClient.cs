using System;
using static Microsoft.Azure.Compute._2016_06_30;

namespace Microsoft.Azure.Compute.Internal2016_06_30
{
    internal sealed class ComputeClient :
        IClient
    {
        public IVirtualMachinesOperations VirtualMachines { get; }

        public IDisksOperations Disks { get; }

        public ComputeClient(string connectionStringEtc)
        {
            VirtualMachines = new VirtualMachineOperations();
            Disks = new DisksOperations();
        }
    }
}
