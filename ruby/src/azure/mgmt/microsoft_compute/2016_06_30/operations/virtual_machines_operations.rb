require_relative "../models/virtual_machine"

module Azure
  module Mgmt
    module Compute
      module Api_2016_06_30
        module Operations
          class VirtualMachinesOperations
            def initialize(client)
            end

            def create(name: , location:, tags: nil, vm_id: nil, disk:, vm_super_power: nil)
              Azure::Mgmt::Compute::Api_2016_06_30::Models::VirtualMachine.new(name: name,
                                                                               location: location,
                                                                               tags: tags,
                                                                               vm_id: vm_id,
                                                                               vm_super_power:vm_super_power)
            end
          end
        end
      end
    end
  end
end