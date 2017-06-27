using System.Collections.Generic;

namespace Microsoft.Azure.Compute
{
    public abstract partial class _2016_06_30
    {
        public interface IDisksOperations
        {
            Disk Create(
                string name,
                string location,
                IDictionary<string, string> tags = null,
                int? diskSizeGB = null,
                string ownerId = null);
        }
    }
}
