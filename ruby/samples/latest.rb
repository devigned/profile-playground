require "../src/azure/mgmt/profiles/latest/client"

puts "Created an Azure Profile of the Latest Operations versions"
latest_client = Azure::Mgmt::Profiles::Latest::Client.new

puts "Creating a new disk of the type defined in the profile for use in VM create"
disk = latest_client.compute.model_types.disk.new(name: "myDisk",
                                                  location: "westus",
                                                  tags: {buzz: "baz"},
                                                  disk_size_gb: 80,
                                                  owner_id: "owner_id")
puts "Disk: #{disk.inspect}"
vm = latest_client.compute.virtual_machines.create(name: "myVm",
                                                   location: "westus",
                                                   tags: {foo: "bar"},
                                                   vm_id: "vmID",
                                                   vm_super_power: "super_power",
                                                   disk: disk)
puts "Virtual Machine: #{vm.inspect}"


##### Output #####
# Created an Azure Profile of the Latest Operations versions
# Creating a new disk of the type defined in the profile for use in VM create
# Disk: #<Azure::Mgmt::Compute::Api_2016_06_30::Models::Disk:0x007fdd4a103900
#   @id="id_from_resource",
#   @name="myDisk",
#   @type="type_from_resource",
#   @location="westus",
#   @tags={:buzz=>"baz"},
#   @provisioning_state="provisioning_state",
#   @disk_size_gb=80,
#   @owner_id="owner_id">
# Virtual Machine: #<Azure::Mgmt::Compute::Api_2016_06_30::Models::VirtualMachine:0x007fdd4a102ff0
#   @id="id_from_resource",
#   @name="myVm",
#   @type="type_from_resource",
#   @location="westus",
#   @tags={:foo=>"bar"},
#   @provisioning_state="creating",
#   @vm_id="vmID",
#   @vm_super_power="super_power">
