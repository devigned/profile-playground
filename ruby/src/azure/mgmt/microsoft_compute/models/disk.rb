require_relative "../../models/resource"

module Azure
  module Mgmt
    module Compute
      module Models
        class Disk < Azure::Mgmt::Models::Resource
          attr_accessor :provisioning_state

          def initialize
            super
            self.provisioning_state = "provisioning_state inside of Azure::Mgmt::Models::Compute::Disk"
          end
        end
      end
    end
  end
end
