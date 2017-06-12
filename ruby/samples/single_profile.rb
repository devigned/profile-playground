require_relative "../src/azure/mgmt/profiles/2017_01_31/client"

puts "Created an Azure Profile for date 2017-01-31"
azure_client = Azure::Mgmt::Profiles::Api_2017_01_31::Client.new

puts "Creating a new disk of the type defined in the profile for use in VM create"
disk = azure_client.compute.model_types.disk.new(name: "myDisk",
                                                 location: "westus",
                                                 tags: {buzz: "baz"},
                                                 disk_size_gb: 80,
                                                 owner_id: "owner_id")
puts "Disk: #{disk.inspect}"
vm = azure_client.compute.virtual_machines.create(name: "myVm",
                                                  location: "westus",
                                                  tags: {foo: "bar"},
                                                  vm_id: "vmID",
                                                  disk: disk)
puts "Virtual Machine: #{vm.inspect}"

##### Output ######
# Created an Azure Profile for date 2017-01-31
# Creating a new disk of the type defined in the profile for use in VM create
# Disk: #<Azure::Mgmt::Compute::Api_2016_06_30::Models::Disk:0x007fddc906a2f8
#   @id="id_from_resource",
#   @name="myDisk",
#   @type="type_from_resource",
#   @location="westus",
#   @tags={:buzz=>"baz"},
#   @provisioning_state="provisioning_state",
#   @disk_size_gb="80",
#   @owner_id="owner_id">
# Virtual Machine: #<Azure::Mgmt::Compute::Api_2016_01_31::Models::VirtualMachine:0x007fddc9069c18
#   @id="id_from_resource",
#   @name="myVm",
#   @type="type_from_resource",
#   @location="westus",
#   @tags={:foo=>"bar"},
#   @provisioning_state="creating",
#   @vm_id="vmID">

