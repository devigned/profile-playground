using System;
using System.Collections.Generic;
using static Microsoft.Azure.Compute._2016_06_30;

namespace Microsoft.Azure.Compute.Internal2016_06_30
{
    internal sealed class DisksOperations : IDisksOperations
    {
        public Disk Create(
            string name,
            string location,
            IDictionary<string, string> tags = null,
            int? diskSizeGB = default(int?),
            string ownerId = null)
        {
            throw new NotImplementedException();
        }
    }
}
