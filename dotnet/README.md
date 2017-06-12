# Samples for Azure ARM Profiles in .NET

Provide a prototype implementation of ARM Profiles in a statically typed language.

## Specific Goals of the Prototype
- Provide a strongly typed model for Azure Profiles
- Minimize developer pain when updating to newer versions of the client libraries
- Provide an interface composition structure which provides flexibility of defining `Models` while giving backward
  comparability via a shared hierarchy of interfaces.
- Everything should be exposed via an interface to allow developers to mock the client easily 
  (not 100% done in the prototype)
  
## Model Interface Composition Hierarchy

```
Azure.Mgmt.Models.IResource
<-- Azure.Mgmt.Compute.Models.IDisk
<-- Azure.Mgmt.Compute._2016_01_31.Models.Disk
<-- Azure.Mgmt.Compute._2016_06_30.Models.Disk
```

Each of the interfaces above builds off of the previous interface. Baring a breaking change of the interface of the
model, this allows for backward comparability of the model without introducing inheritance.

## Profiles Expressed in Code
Profile clients are the entry point to model instance constructors as well as strongly typed operations. Profiles
should be generated via code generation, but could easily be written by hand as well.

## Structure of the Prototype

```
$ tree .
.
├── LICENSE
├── README.md
├── profile-playground.csproj
├── samples
│   ├── LatestSample.cs
│   ├── MultiProfileSample.cs
│   └── ProfileSample.cs
└── src
    └── Azure
        └── Mgmt
            ├── AzureClient.cs
            ├── Microsoft.Compute
            │   ├── 2016_01_31
            │   │   ├── Models
            │   │   │   ├── Plan.cs
            │   │   │   └── VirtualMachine.cs
            │   │   └── Operations
            │   │       └── VirtualMachinesOperations.cs
            │   ├── 2016_06_30
            │   │   ├── Models
            │   │   │   ├── Disk.cs
            │   │   │   ├── Plan.cs
            │   │   │   └── VirtualMachine.cs
            │   │   └── Operations
            │   │       ├── DisksOperations.cs
            │   │       └── VirtualMachinesOperations.cs
            │   └── Models
            │       ├── Disk.cs
            │       ├── Plan.cs
            │       └── VirtualMachine.cs
            ├── Models
            │   └── Resource.cs
            └── Profiles
                ├── 2017_01_31
                │   ├── Client.cs
                │   └── profile.json
                ├── 2017_05_15
                │   ├── Client.cs
                │   └── profile.json
                └── Latest
                    └── Client.cs
```

### [Samples of Azure Profile Usage](./samples)
The samples directory contains three scenarios for developer interaction.

#### [Single Profile](./samples/ProfileSample.cs)
This sample provides an example of using a single, specific profile. This is expected to be the most common use case.
The developer can choose the profile by including the namespace of the profile, At that point, they are locked into
those API versions and can update the version of their client libraries without the fear of introducing breaking changes.

#### [Latest Profile](./samples/LatestSample.cs)
This sample provides an example using the `Latest` profile, a virtual profile which contains the latest and greatest
API versions published. The API exposed by this version will be open to breaking changes due to always including the
latest changes. This is only useful for developers that need to work with the latest version of Azure services.

I think this is the second most common use case.

#### [Multiple Profile Side by Side](./samples/MultiProfileSample.cs)
This sample provides an example using two different Azure Profile versions side by side. This is likely to be the
most common use case for anyone developing DevOps tools on top of Azure.