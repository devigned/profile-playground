using System.Collections.Generic;

namespace Azure.Mgmt.Models {
    public class Resource {
        /// <summary>
        /// Gets resource Id
        /// </summary>
        public string Id { get; protected set; }

        /// <summary>
        /// Gets resource name
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        public string Type { get; protected set; }

        /// <summary>
        /// Gets or sets resource location
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        public IDictionary<string, string> Tags { get; set; }
    }
}