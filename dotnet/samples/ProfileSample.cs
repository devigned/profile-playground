using Azure.Mgmt.Profiles._2017_01_31;

public class ProfileSample {
    public ProfileSample(){
        var profile = new Client();
        var plan = profile.Compute.Models.Plan("newPlan", "publisher", "promoCode");
        var vm = profile.Compute.VirtualMachines.Create("blah", plan);

        // Properties available on VM in the 2017_01_31 profile
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