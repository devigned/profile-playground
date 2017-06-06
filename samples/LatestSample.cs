using Azure.Mgmt.Profiles.Latest;

public class LatestSample {
    public LatestSample(){
        var latestClient = new Client();
        var vm = latestClient.Compute.VirtualMachines.Create();

        // Properties available on VM in the latest version of the APIs
        var id = vm.Id;
        var provisioningState = vm.ProvisioningState;
        var licenseType = vm.LicenseType;
        var name = vm.Name;

        var disk = latestClient.Compute.Disks.Create();
        var diskSizeGB = disk.DiskSizeGB;
        var ownerId = disk.OwnerId;
    }
}