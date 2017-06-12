# Samples for Azure ARM Profiles in Ruby

Provide a prototype implementation of ARM Profiles in a dynamic typed language

## Specific Goals of the Prototype
- Provide as much information to the code editor as possible to empower developers
- Minimize developer pain when updating to newer versions of the client libraries

## Structure of the Prototype

```
.
├── Gemfile
├── Gemfile.lock
├── README.md
├── samples
│   ├── latest.rb
│   ├── multi_profile.rb
│   └── single_profile.rb
└── src
    └── azure
        └── mgmt
            ├── azure_client.rb
            ├── microsoft_compute
            │   ├── 2016_01_31
            │   │   ├── models
            │   │   │   └── virtual_machine.rb
            │   │   └── operations
            │   │       └── virtual_machines_operations.rb
            │   ├── 2016_06_30
            │   │   ├── models
            │   │   │   ├── disk.rb
            │   │   │   └── virtual_machine.rb
            │   │   └── operations
            │   │       ├── disks_operations.rb
            │   │       └── virtual_machines_operations.rb
            │   └── models
            │       ├── disk.rb
            │       └── virtual_machine.rb
            ├── models
            │   └── resource.rb
            └── profiles
                ├── 2017_01_31
                │   ├── client.rb
                │   └── profile.json
                ├── 2017_05_15
                │   ├── client.rb
                │   └── profile.json
                └── latest
                    └── client.rb
```

### [Samples of Azure Profile Usage](./samples)
The samples directory contains three scenarios for developer interaction.

#### [Single Profile](./samples/single_profile.rb)
This sample provides an example of using a single, specific profile. This is expected to be the most common use case.
The developer can choose the profile by including the namespace of the profile, At that point, they are locked into
those API versions and can update the version of their client libraries without the fear of introducing breaking changes.

#### [Latest Profile](./samples/latest.rb)
This sample provides an example using the `Latest` profile, a virtual profile which contains the latest and greatest
API versions published. The API exposed by this version will be open to breaking changes due to always including the
latest changes. This is only useful for developers that need to work with the latest version of Azure services.

I think this is the second most common use case.

#### [Multiple Profile Side by Side](./samples/multi_profile.rb)
This sample provides an example using two different Azure Profile versions side by side. This is likely to be the
most common use case for anyone developing DevOps tools on top of Azure.
