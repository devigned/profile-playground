require_relative "../src/azure/mgmt/profiles/2017_01_31/client"
require_relative "../src/azure/mgmt/profiles/2017_05_15/client"

puts "Using Profile 2017-01-31"
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


puts "\n\nUsing Profile 2017-05-15"
azure_client = Azure::Mgmt::Profiles::Api_2017_05_15::Client.new
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
                                                  disk: disk,
                                                  vm_super_power: "super_power")
puts "Virtual Machine: #{vm.inspect}"


##### Output ######
# Using Profile 2017-01-31
# Creating a new disk of the type defined in the profile for use in VM create
# Disk: #<Azure::Mgmt::Compute::Api_2016_06_30::Models::Disk:0x007f9b448f2be0
#   @id="id_from_resource",
#   @name="myDisk",
#   @type="type_from_resource",
#   @location="westus",
#   @tags={:buzz=>"baz"},
#   @provisioning_state="provisioning_state",
#   @disk_size_gb=80,
#   @owner_id="owner_id">
# Virtual Machine: #<Azure::Mgmt::Compute::Api_2016_01_31::Models::VirtualMachine:0x007f9b448f2758
#   @id="id_from_resource",
#   @name="myVm",
#   @type="type_from_resource",
#   @location="westus",
#   @tags={:foo=>"bar"},
#   @provisioning_state="creating",
#   @vm_id="vmID">
#
#
# Using Profile 2017-05-15
# Creating a new disk of the type defined in the profile for use in VM create
# Disk: #<Azure::Mgmt::Compute::Api_2016_06_30::Models::Disk:0x007f9b448f2118
#   @id="id_from_resource",
#   @name="myDisk",
#   @type="type_from_resource",
#   @location="westus",
#   @tags={:buzz=>"baz"},
#   @provisioning_state="provisioning_state inside of Azure::Mgmt::Models::Compute::Disk",
#   @disk_size_gb=80,
#   @owner_id="owner_id">
# Virtual Machine: #<Azure::Mgmt::Compute::Api_2016_06_30::Models::VirtualMachine:0x007fad9805ad50
#   @id="id_from_resource",
#   @name="myVm",
#   @type="type_from_resource",
#   @location="westus",
#   @tags={:foo=>"bar"},
#   @provisioning_state="creating",
#   @vm_id="vmID",
#   @vm_super_power="super_power">

