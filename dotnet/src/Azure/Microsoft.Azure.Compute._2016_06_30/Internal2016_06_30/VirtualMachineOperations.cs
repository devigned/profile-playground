using System;
using System.Collections.Generic;
using static Microsoft.Azure.Compute._2016_06_30;

namespace Microsoft.Azure.Compute.Internal2016_06_30
{
    public sealed class VirtualMachineOperations : IVirtualMachinesOperations
    {
        public VirtualMachine Create(
            string name,
            string location,
            IDictionary<string, string> tags = null,
            string licenseType = null,
            Plan plan = null)
        {
            throw new NotImplementedException();
        }
    }
}
