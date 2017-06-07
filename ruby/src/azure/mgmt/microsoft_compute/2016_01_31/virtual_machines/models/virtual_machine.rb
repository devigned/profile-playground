require_relative "../../../models/virtual_machine"

module Azure
  module Mgmt
    module Compute
      module Api_2016_01_31
        module Models
          class VirtualMachine < Azure::Mgmt::Compute::Models::VirtualMachine
            attr_accessor :vm_id

            def initialize
              super
              self.vm_id = "vm_id inside of Api_2016_01_31"
            end
          end
        end
      end
    end
  end
end