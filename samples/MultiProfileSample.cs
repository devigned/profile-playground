using _2017_01_31=Azure.Mgmt.Profiles._2017_01_31;
using _2017_05_15=Azure.Mgmt.Profiles._2017_05_15;

public class MultiProfileSample {
    public MultiProfileSample(){
        var profile_2017_01_31 = new _2017_01_31.Client();
        var vm = profile_2017_01_31.Compute.VirtualMachines.Create();

        // Properties available on VM in the latest version of the APIs
        var id = vm.ID;
        var baseProp = vm.BaseVMProperty;
        var prop2016_01_31 = vm.Prop2016_01_31;
        // var prop2016_06_30 = vm.Prop2016_06_30; This version doesn't exist, so would cause a compile failure

        var disk = profile_2017_01_31.Compute.Disks.Create();
        baseProp = disk.BaseDiskProperty;
        var prop2016_06_30 = disk.Prop2016_06_30;


        var profile_2017_05_15 = new _2017_05_15.Client();
        var newerVM = profile_2017_05_15.Compute.VirtualMachines.Create();

        // Properties available on VM in the latest version of the APIs
        id = newerVM.ID;
        baseProp = newerVM.BaseVMProperty;
        prop2016_01_31 = newerVM.Prop2016_01_31;
        prop2016_06_30 = newerVM.Prop2016_06_30; 

        var newerDisk = profile_2017_05_15.Compute.Disks.Create();
        baseProp = disk.BaseDiskProperty;
        prop2016_06_30 = disk.Prop2016_06_30;

        vm = newerVM; // the models have an inheritance hierarchy
    }
}