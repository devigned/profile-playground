using System.Collections.Generic;

namespace Microsoft.Azure.Compute
{
    public abstract partial class _2016_01_31
    {
        public class Resource
        {
            public Resource(
                string id,
                string name,
                string type,
                string location,
                IDictionary<string, string> tags = null)
            {
                Id = id;
                Name = name;
                Type = type;
                Location = location;
                Tags = tags;
            }

            /// <summary>
            /// Gets resource Id
            /// </summary>
            public string Id { get; }

            /// <summary>
            /// Gets resource name
            /// </summary>
            public string Name { get; }

            /// <summary>
            /// Gets resource type
            /// </summary>
            public string Type { get; }

            /// <summary>
            /// Gets or sets resource location
            /// </summary>
            public string Location { get; }

            /// <summary>
            /// Gets or sets resource tags
            /// </summary>
            public IDictionary<string, string> Tags { get; }
        }
    }
}
