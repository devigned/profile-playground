module Azure
  module Mgmt
    class AzureClient
      attr_accessor :base_uri, :credentials, :subscription_id, :accepted_language, :long_running_operation_timeout,
                    :generate_client_request_id
    end
  end
end