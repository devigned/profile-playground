using Azure.Mgmt.Profiles._2017_01_31;

public class ProfileSample {
    public ProfileSample(){
        var profile = new Client();
        var vm = profile.Compute.VirtualMachines.Create();

        // Properties available on VM in the latest version of the APIs
        var id = vm.Id;
        var provisioningState = vm.ProvisioningState;
        var licenseType = vm.LicenseType;
        var name = vm.Name;
        // var vmId = vm.VmId;  // doesn't exist in this profile

        var disk = profile.Compute.Disks.Create();
        var diskSizeGB = disk.DiskSizeGB;
        var ownerId = disk.OwnerId;
    }
}