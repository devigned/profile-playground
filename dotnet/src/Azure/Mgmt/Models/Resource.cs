using System.Collections.Generic;

namespace Azure.Mgmt.Models {

    public interface IResource {
        /// <summary>
        /// Gets resource Id
        /// </summary>
        string Id { get; }

        /// <summary>
        /// Gets resource name
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        string Type { get; }

        /// <summary>
        /// Gets or sets resource location
        /// </summary>
        string Location { get; set; }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        IDictionary<string, string> Tags { get; set; }
    }

    public abstract class Resource : IResource {
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