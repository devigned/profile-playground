using System;
using static Microsoft.Azure.Compute._2016_01_31;

namespace Microsoft.Azure.Compute.Internal2016_01_31
{
    internal sealed class ComputeClient :
        IClient
    {
        public IVirtualMachinesOperations VirtualMachines
            => throw new NotImplementedException();

        public ComputeClient(string connectionStringEtc)
        {
        }
    }
}
