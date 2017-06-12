require_relative "../models/virtual_machine"

module Azure
  module Mgmt
    module Compute
      module Api_2016_01_31
        module Operations
          class VirtualMachinesOperations
            def initialize(client)
            end

            def create(name:, location:, tags: nil, vm_id: nil, disk:)
              Azure::Mgmt::Compute::Api_2016_01_31::Models::VirtualMachine.new(name: name,
                                                                               location: location,
                                                                               tags: tags,
                                                                               vm_id: vm_id)
            end
          end
        end
      end
    end
  end
end