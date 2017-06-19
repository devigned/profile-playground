using Azure.Mgmt.Profiles.Latest;
using specificCompute = Azure.Mgmt.Compute._2016_01_31;

public class SpecificVersionSample {

    public SpecificVersionSample(){

        /* 
        * This sample creates a specific (resource type, Azure API version) request using an Azure client and a set 
        * of models and operations sourced from an API version specific namespace of Compute resources. 
        * This usage scenario is shown to illustrate a API consumer whom needs to access API versions which are 
        * not part of one of the curated Azure Profiles.
        */

        var client = new Client();
        var vmOperations = new specificCompute.Operations.VirtualMachinesOperations(client);
        var plan = new specificCompute.Models.Plan(name: "planName", publisher: "publisher", promotionCode: "code");
        var vm = vmOperations.Create(name: "myVm", location: "westus", licenseType: "MIT", plan: plan);

        // Properties available on VM in the 2017_01_31 profile
        var id = vm.Id;
        var provisioningState = vm.ProvisioningState;
        var licenseType = vm.LicenseType;
        var name = vm.Name;
    }
}