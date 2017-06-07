require_relative "../models/disk"

module Azure
  module Mgmt
    module Compute
      module Api_2016_06_30
        module Operations
          class DisksOperations
            def initialize(client)
            end

            def create
              Azure::Mgmt::Compute::Api_2016_06_30::Models::Disk.new
            end
          end
        end
      end
    end
  end
end