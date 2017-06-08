require_relative "../../microsoft_compute/2016_01_31/virtual_machines/operations/virtual_machines_operations"
require_relative "../../microsoft_compute/2016_06_30/disks/operations/disks_operations"

module Azure
  module Mgmt
    module Profiles
      module Api_2017_01_31
        class Compute
          attr_accessor :virtual_machines, :disks
          def initialize(client)
            self.virtual_machines = Azure::Mgmt::Compute::Api_2016_01_31::Operations::VirtualMachinesOperations.new(client)
            self.disks = Azure::Mgmt::Compute::Api_2016_06_30::Operations::DisksOperations.new(client)
          end
        end

        class Client
          attr_accessor :compute
          def initialize
            self.compute = Compute.new(self)
          end
        end
      end
    end
  end
end