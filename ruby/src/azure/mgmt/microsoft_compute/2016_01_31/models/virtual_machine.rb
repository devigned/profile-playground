require_relative "../../models/virtual_machine"

module Azure
  module Mgmt
    module Compute
      module Api_2016_01_31
        module Models
          class VirtualMachine < Azure::Mgmt::Compute::Models::VirtualMachine
            attr_accessor :vm_id

            def initialize(name:, location:, tags: nil, vm_id: nil)
              super(name: name, location: location, tags: tags)
              self.vm_id = vm_id
            end
          end
        end
      end
    end
  end
end