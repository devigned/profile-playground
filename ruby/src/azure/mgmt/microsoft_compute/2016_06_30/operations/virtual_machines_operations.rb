require_relative "../models/virtual_machine"

module Azure
  module Mgmt
    module Compute
      module Api_2016_06_30
        module Operations
          module VirtualMachinesOperations
            extend ActiveSupport::Concern

            class Operations
              attr_accessor :client

              def initialize(client)
                self.client = client
              end

              def create
                # using a client create a VM and return it
                Azure::Mgmt::Compute::Api_2016_06_30::Models::VirtualMachine.new
              end
            end

            included do
              def virtual_machines
                Operations.new(self)
              end
            end
          end
        end
      end
    end
  end
end