require_relative "../../microsoft_compute/2016_06_30/operations/virtual_machines_operations"
require_relative "../../microsoft_compute/2016_06_30/operations/disks_operations"
require_relative "../../azure_client"
require_relative "../operations_base"

module Azure
  module Mgmt
    module Profiles
      module Api_2017_05_15
        module Compute
          extend ActiveSupport::Concern

          class InternalCompute < OperationsBase
            include Azure::Mgmt::Compute::Api_2016_06_30::Operations::VirtualMachinesOperations
            include Azure::Mgmt::Compute::Api_2016_06_30::Operations::DisksOperations
          end

          included do
            def compute
              InternalCompute.new(self)
            end
          end
        end

        class Client < Azure::Mgmt::AzureClient
          include Compute
        end
      end
    end
  end
end