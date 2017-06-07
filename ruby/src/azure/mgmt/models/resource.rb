module Azure
  module Mgmt
    module Models
      class Resource
        attr_accessor :id, :name, :type, :location, :tags

        def initialize
            self.id = "id inside of Azure::Mgmt::Models::Resource"
            self.name = "name inside of Azure::Mgmt::Models::Resource"
            self.type = "type inside of Azure::Mgmt::Models::Resource"
            self.location = "location inside of Azure::Mgmt::Models::Resource"
            self.tags = "tags inside of Azure::Mgmt::Models::Resource"
        end
      end
    end
  end
end