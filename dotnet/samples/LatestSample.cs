using Azure.Mgmt.Profiles.Latest;

public class LatestSample {
    public LatestSample(){
        var latestClient = new Client();
        var plan = latestClient.Compute.Models.Plan("name", "publisher", "product", "promotionCode");
        var vm = latestClient.Compute.VirtualMachines.Create("licenseType", "vmId", plan);

        // Properties available on VM in the 2017_01_31 profile
        var id = vm.Id;
        var provisioningState = vm.ProvisioningState;
        var licenseType = vm.LicenseType;
        var name = vm.Name;
        var vmId = vm.VmId;

        var disk = latestClient.Compute.Disks.Create();
        var diskSizeGB = disk.DiskSizeGB;
        var ownerId = disk.OwnerId;
    }
}