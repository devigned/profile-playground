require_relative "../src/azure/mgmt/profiles/2017_01_31/client"

puts "Profile 2017-01-31"
profile_2017_01_31 = Azure::Mgmt::Profiles::Api_2017_01_31::Client.new
vm = profile_2017_01_31.compute.virtual_machines.create
puts "Virtual Machine: #{vm.inspect}"

disk = profile_2017_01_31.compute.disks.create
puts "Disk: #{disk.inspect}"