require_relative "../../microsoft_compute/2016_06_30/operations/virtual_machines_operations"
require_relative "../../microsoft_compute/2016_06_30/operations/disks_operations"
require_relative "../../azure_client"

module Azure
  module Mgmt
    module Profiles
      module Latest
        class Compute
          attr_accessor :virtual_machines, :disks, :model_types
          def initialize(client)
            self.virtual_machines = Azure::Mgmt::Compute::Api_2016_06_30::Operations::VirtualMachinesOperations.new(client)
            self.disks = Azure::Mgmt::Compute::Api_2016_06_30::Operations::DisksOperations.new(client)
            self.model_types = ModelTypes.new
          end
        end

        class ModelTypes
          def virtual_machine
            Azure::Mgmt::Compute::Api_2016_06_30::Models::VirtualMachine
          end

          def disk
            Azure::Mgmt::Compute::Api_2016_06_30::Models::Disk
          end
        end


        class Client < Azure::Mgmt::AzureClient
          attr_accessor :compute
          def initialize
            self.compute = Compute.new(self)
          end
        end
      end
    end
  end
end