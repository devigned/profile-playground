require "../src/azure/mgmt/profiles/latest/client"

latest_client = Azure::Mgmt::Profiles::Latest::Client.new

vm = latest_client.compute.virtual_machines.create
puts "Virtual Machine: #{vm.inspect}"

disk = latest_client.compute.disks.create
puts "Disk: #{disk.inspect}"