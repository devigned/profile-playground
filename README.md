# Prototype for Azure ARM Profiles

Azure Profiles provide a set of ARM **Resource Type, Version** combinations, which represent a long term supported set
of APIs. That is to say, for a given Azure Profile, we may need to combine any set of resource types 
(`Microsoft.Compute/VirtualMachine`, `Microsoft.Compute/Disk`, etc...) and ARM API versions. Valid sets would look
like the following:

```json
{
    "resourceTypeVersions": {
        "Microsoft.Compute/VirtualMachine": "2016_01_31",
        "Microsoft.Compute/Disk": "2016_06_30"
    }
}
```
*Note: the resource type name is a key and can't be repeated*

Profiles are used to provide hybrid cloud spanning sets of APIs to ensure cross cloud usability of tools. These
prototypes have been created to explore the optimal way of exposing these features to cloud developers.

I will refer to `client libaries` throughout this prototype. This specifically means the code and semantic 
versioning of the publicly published Nuget and Rubygems packages. The semantic version of these packages is not
tied to the API versions included in the package, but rather the code surface exposed publicly to the developer
(excluding the Latest Profile -- see the Goals section for details). It is expected the client libraries will 
contain all known API versions and resource types to date, or at a minimum all API versions which are used by
Azure Profiles.

## Goals
- Expose Azure Profiles (curated sets of resource types and API versions)
- Provide ability to use multiple Azure ARM API versions side by side
- Provide a simple interface for using a specific API version
- Allow customers to lock into an individual Azure Profile version
- Provide a easy way to update to a new Azure Profile version
- Ensure no breaking changes to existing Azure Profiles upon package updates
  (when moving from version 1.0 to version 1.1 of Azure ARM client libraries)
- Provide a `Latest` Azure Profile version which will contain all of the latest
  Azure ARM APIs. The assumption, is that this virtual Azure Profile will be unstable
  and introduce breaking changes during client library semantic version increases
  outside of major version only (including minor and patch version updates).

## [Statically Typed Prototype: .NET](./dotnet)
Provides an example of a staticly typed language prototype located [here](./dotnet).

## [Dynamically Typed Prototype: Ruby](./ruby)
Provides an example of a dynamic typed language prototype located [here](./ruby).