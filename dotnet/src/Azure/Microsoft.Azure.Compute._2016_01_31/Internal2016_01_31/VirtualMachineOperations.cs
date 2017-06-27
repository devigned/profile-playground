using System;
using System.Collections.Generic;
using static Microsoft.Azure.Compute._2016_01_31;

namespace Microsoft.Azure.Compute.Internal2016_01_31
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
