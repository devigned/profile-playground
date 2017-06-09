require_relative "../../microsoft_compute/2016_06_30/operations/virtual_machines_operations"
require_relative "../../microsoft_compute/2016_06_30/operations/disks_operations"
require_relative "../../azure_client"

module Azure
  module Mgmt
    module Profiles
      module Latest
        class Compute
          attr_accessor :virtual_machines, :disks
          def initialize(client)
            self.virtual_machines = Azure::Mgmt::Compute::Api_2016_06_30::Operations::VirtualMachinesOperations.new(client)
            self.disks = Azure::Mgmt::Compute::Api_2016_06_30::Operations::DisksOperations.new(client)
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