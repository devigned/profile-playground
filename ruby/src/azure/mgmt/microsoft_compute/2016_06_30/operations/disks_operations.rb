require_relative "../models/disk"

module Azure
  module Mgmt
    module Compute
      module Api_2016_06_30
        module Operations
          class DisksOperations
            def initialize(client)
            end

            def create(name:, location:, tags: nil, disk_size_gb: nil, owner_id: nil)
              Azure::Mgmt::Compute::Api_2016_06_30::Models::Disk.new(name: name,
                                                                     location: location,
                                                                     tags: tags,
                                                                     disk_size_gb: disk_size_gb,
                                                                     owner_id: owner_id)
            end
          end
        end
      end
    end
  end
end