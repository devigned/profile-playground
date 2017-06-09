require_relative "../../models/disk"


module Azure
  module Mgmt
    module Compute
      module Api_2016_06_30
        module Models
          class Disk < Azure::Mgmt::Compute::Models::Disk
            attr_accessor :disk_size_gb, :owner_id

            def initialize
              super
              self.disk_size_gb = "disk_size_gb inside of Api_2016_06_30"
              self.owner_id = "owner_id inside of Api_2016_06_30"
            end
          end
        end
      end
    end
  end
end