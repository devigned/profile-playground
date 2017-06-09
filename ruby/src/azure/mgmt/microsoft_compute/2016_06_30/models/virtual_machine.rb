require_relative "../../2016_01_31/models/virtual_machine"

module Azure
  module Mgmt
    module Compute
      module Api_2016_06_30
        module Models
          class VirtualMachine < Azure::Mgmt::Compute::Api_2016_01_31::Models::VirtualMachine
            attr_accessor :vm_super_power

            def initialize
              super
              self.vm_super_power = "vm_super_power inside of Api_2016_06_30"
            end
          end
        end
      end
    end
  end
end