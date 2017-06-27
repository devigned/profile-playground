namespace Microsoft.Azure.Compute
{
    public abstract partial class _2016_01_31
    {
        public interface IClient
        {
            IVirtualMachinesOperations VirtualMachines { get; }
        }

        public static IClient Create(string connectionStringEtc)
            => new Internal2016_01_31.ComputeClient(connectionStringEtc);
    }
}
