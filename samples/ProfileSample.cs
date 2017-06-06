using Azure.Mgmt.Profiles._2017_01_31;

public class ProfileSample {
    public ProfileSample(){
        var profile = new Client();
        var vm = profile.Compute.VirtualMachines.Create();

        // Properties available on VM in the latest version of the APIs
        var id = vm.ID;
        var baseProp = vm.BaseVMProperty;
        var prop2016_01_31 = vm.Prop2016_01_31;
        // var prop2016_06_30 = vm.Prop2016_06_30; This version doesn't exist, so would cause a compile failure

        var disk = profile.Compute.Disks.Create();
        baseProp = disk.BaseDiskProperty;
        // prop2016_01_31 = disk.Prop2016_01_31;  This version for disk doesn't exist, so this would cause a compile failure
        var prop2016_06_30 = disk.Prop2016_06_30;
    }
}