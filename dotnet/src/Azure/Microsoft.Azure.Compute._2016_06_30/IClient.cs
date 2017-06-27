namespace Microsoft.Azure.Compute
{
    public abstract partial class _2016_06_30
    {
        public interface IClient
        {
            IVirtualMachinesOperations VirtualMachines { get; }
            IDisksOperations Disks { get; }
        }

        public static IClient CreateClient(string connectionStringEtc)
            => new Internal2016_06_30.ComputeClient(connectionStringEtc);
    }
}
