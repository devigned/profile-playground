using System.Collections.Generic;

namespace Microsoft.Azure.Compute
{
    public abstract partial class _2016_06_30
    {
        public interface IVirtualMachinesOperations
        {
            VirtualMachine Create(
                string name,
                string location,
                IDictionary<string, string> tags = null,
                string licenseType = null,
                Plan plan = null);
        }
    }
}
