using Profile_2017_01_31=Azure.Mgmt.Profiles._2017_01_31;
using Profile_2017_05_15=Azure.Mgmt.Profiles._2017_05_15;

public class MultiProfileSample {
    public MultiProfileSample(){
        var olderAzure = new Profile_2017_01_31.Client();
        // Properties available on VM in the 2017_01_31 profile

        var plan = olderAzure.Compute.Models.Plan(name: "planName", publisher: "publisher", promotionCode: "code");
        var vm = olderAzure.Compute.VirtualMachines.Create(name: "myVm", location: "westus", licenseType: "MIT", plan: plan);
        var id = vm.Id;
        var provisioningState = vm.ProvisioningState;
        var licenseType = vm.LicenseType;
        var name = vm.Name;
        // var vmId = vm.vmId; compile error

        var newerAzure = new Profile_2017_05_15.Client();
        var newerPlan = newerAzure.Compute.Models.Plan(name: "planName", publisher: "publisher", product: "product", promotionCode: "code");
        vm = newerAzure.Compute.VirtualMachines.Create(name: "myVm", location: "westus", licenseType: "MIT", plan: newerPlan);
        // var vmId = vm.VmId;  <--- still a compile error since vm is the older interface

        var newerVM = newerAzure.Compute.VirtualMachines.Create(name: "myVm", location: "westus", licenseType: "MIT", plan: newerPlan);
        var vmId = newerVM.VmId; // <--- this works, now that we have a newer VM interface


        olderAzure.Compute.VirtualMachines.Create(name: "myVm", location: "westus", licenseType: "MIT", plan: newerPlan);
        vm = newerVM;

        vm.Plan = plan; // <--- this will cause a runtime error because it can't project an old plan into the future
    }
}