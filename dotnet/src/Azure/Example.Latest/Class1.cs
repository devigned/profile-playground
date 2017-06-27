using Microsoft.Azure.Compute;

namespace Example
{
    public class Class1
    {
        public Latest.IVirtualMachinesOperations operations = null;

        void Func()
        {
            var client = Latest.CreateClient("connection string");
            operations = client.VirtualMachines;
            operations.Create("a", "b");
        }
    }
}
