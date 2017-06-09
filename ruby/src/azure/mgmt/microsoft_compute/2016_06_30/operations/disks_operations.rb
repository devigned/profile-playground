require_relative "../models/disk"

module Azure
  module Mgmt
    module Compute
      module Api_2016_06_30
        module Operations
          module DisksOperations
            extend ActiveSupport::Concern

            class Operations
              attr_accessor :client

              def initialize(client)
                self.client = client
              end

              def create
                Azure::Mgmt::Compute::Api_2016_06_30::Models::Disk.new
              end
            end

            included do
              def disks
                Operations.new(self)
              end
            end
          end
        end
      end
    end
  end
end