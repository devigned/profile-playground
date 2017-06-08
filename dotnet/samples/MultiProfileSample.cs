using Profile_2017_01_31=Azure.Mgmt.Profiles._2017_01_31;
using Profile_2017_05_15=Azure.Mgmt.Profiles._2017_05_15;

public class MultiProfileSample {
    public MultiProfileSample(){
        var profile_2017_01_31 = new Profile_2017_01_31.Client();
        // Properties available on VM in the 2017_01_31 profile

        var plan = profile_2017_01_31.Compute.Models.Plan("myPlan", "publisher", "promotionCode");
        var vm = profile_2017_01_31.Compute.VirtualMachines.Create("foo", plan);        
        var id = vm.Id;
        var provisioningState = vm.ProvisioningState;
        var licenseType = vm.LicenseType;
        var name = vm.Name;
        // var vmId = vm.vmId; compile error


        var profile_2017_05_15 = new Profile_2017_05_15.Client();
        var newPlan = profile_2017_05_15.Compute.Models.Plan("newPlan", "publisher", "product", "promoCode");
        var newerVM = profile_2017_05_15.Compute.VirtualMachines.Create("foo", "vmId", newPlan);
        // // Properties available on VM in the 2017_05_15 profile
        id = newerVM.Id;
        provisioningState = newerVM.ProvisioningState;
        licenseType = newerVM.LicenseType;
        name = newerVM.Name;
        var vmId = newerVM.VmId;  // not a compile error

        vm = newerVM; // the models have an inheritance hierarchy
    }
}