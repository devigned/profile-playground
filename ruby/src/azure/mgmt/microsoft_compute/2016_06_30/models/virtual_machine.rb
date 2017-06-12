require_relative "../../2016_01_31/models/virtual_machine"

module Azure
  module Mgmt
    module Compute
      module Api_2016_06_30
        module Models
          class VirtualMachine < Azure::Mgmt::Compute::Api_2016_01_31::Models::VirtualMachine
            attr_accessor :vm_super_power

            def initialize(name:, location:, tags: nil, vm_id: nil, vm_super_power: nil)
              super(name: name, location: location, tags: tags, vm_id: vm_id)
              self.vm_super_power = vm_super_power
            end
          end
        end
      end
    end
  end
end