using Azure.Mgmt.Profiles.Latest;

public class LatestSample {
    public LatestSample(){
        var latestClient = new Client();
        var plan = latestClient.Compute.Models.Plan(name: "planName", publisher: "publisher", product: "product", promotionCode: "code");
        var vm = latestClient.Compute.VirtualMachines.Create(name: "myVm", location: "westus", licenseType: "MIT", vmId: "myVmId", plan: plan);

        // Properties available on VM in the 2017_01_31 profile
        var id = vm.Id;
        var provisioningState = vm.ProvisioningState;
        var licenseType = vm.LicenseType;
        var name = vm.Name;
        var vmId = vm.VmId;

        var disk = latestClient.Compute.Disks.Create("myDisk", "westus", diskSizeGB: 80, ownerId: "ownerId");
        var diskSizeGB = disk.DiskSizeGB;
        var ownerId = disk.OwnerId;
    }
}