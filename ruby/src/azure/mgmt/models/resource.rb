module Azure
  module Mgmt
    module Models
      class Resource
        attr_accessor :id, :name, :type, :location, :tags

        def initialize(name:, location:, tags:nil)
            self.id = "id_from_resource"
            self.name = name
            self.type = "type_from_resource"
            self.location = location
            self.tags = tags
        end
      end
    end
  end
end