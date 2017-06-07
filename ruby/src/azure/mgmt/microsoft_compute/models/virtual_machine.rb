require_relative "../../models/resource"

module Azure
  module Mgmt
    module Compute
      module Models
        class VirtualMachine < Azure::Mgmt::Models::Resource
          attr_accessor :provisioning_state

          def initialize
            super
            self.provisioning_state = "provisioning_state inside of Azure::Mgmt::Models::Compute::VirtualMachine"
          end
        end
      end
    end
  end
end
