require_relative "../../models/disk"


module Azure
  module Mgmt
    module Compute
      module Api_2016_06_30
        module Models
          class Disk < Azure::Mgmt::Compute::Models::Disk
            attr_accessor :disk_size_gb, :owner_id

            def initialize(name:, location:, tags: nil, disk_size_gb: nil, owner_id: nil)
              super(name: name, location: location, tags: tags)
              self.disk_size_gb = disk_size_gb
              self.owner_id = owner_id
            end
          end
        end
      end
    end
  end
end