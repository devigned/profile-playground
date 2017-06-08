require_relative "../models/virtual_machine"

module Azure
  module Mgmt
    module Compute
      module Api_2016_01_31
        module Operations
          class VirtualMachinesOperations
            def initialize(client)
            end

            def create
              Azure::Mgmt::Compute::Api_2016_01_31::Models::VirtualMachine.new
            end
          end
        end
      end
    end
  end
end