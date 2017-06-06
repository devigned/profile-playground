using Azure.Mgmt.Profiles.Latest;

public class LatestSample {
    public LatestSample(){
        var latestClient = new Client();
        var vm = latestClient.Compute.VirtualMachines.Create();

        // Properties available on VM in the latest version of the APIs
        var id = vm.ID;
        var baseProp = vm.BaseVMProperty;
        var prop2016_01_31 = vm.Prop2016_01_31;
        var prop2016_06_30 = vm.Prop2016_06_30;

        var disk = latestClient.Compute.Disks.Create();
        baseProp = disk.BaseDiskProperty;
        // prop2016_01_31 = disk.Prop2016_01_31;  This version for disk doesn't exist, so this would cause a compile failure
        prop2016_06_30 = disk.Prop2016_06_30;
    }
}