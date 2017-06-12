using Azure.Mgmt.Profiles._2017_05_15;

public class ProfileSample {
    public ProfileSample(){
        // Working with the Azure Profile from 2017-01-31
        var azure = new Client();
        var plan = azure.Compute.Models.Plan(name: "planName", publisher: "publisher", product: "product", promotionCode: "code");
        var vm = azure.Compute.VirtualMachines.Create(name: "myVm", location: "westus", vmId: "vm_id_doesnt_exist_in_earlier_versions", licenseType: "MIT", plan: plan);

        // Properties available on VM in the 2017_01_31 profile
        var id = vm.Id;
        var provisioningState = vm.ProvisioningState;
        var licenseType = vm.LicenseType;
        var name = vm.Name;
        // var vmId = vm.VmId;  // doesn't exist in this profile

        var disk = azure.Compute.Disks.Create("myDisk", "westus", diskSizeGB: 80, ownerId: "ownerId");
        var diskSizeGB = disk.DiskSizeGB;
        var ownerId = disk.OwnerId;
    }
}