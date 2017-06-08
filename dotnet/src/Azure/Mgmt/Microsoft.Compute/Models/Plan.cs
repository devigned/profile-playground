
namespace Azure.Mgmt.Compute.Models
{
    /// <summary>
    /// Plan for the resource.
    /// </summary>
    public partial class Plan
    {
        /// <summary>
        /// Initializes a new instance of the Plan class.
        /// </summary>
        public Plan() { }

        /// <summary>
        /// Initializes a new instance of the Plan class.
        /// </summary>
        /// <param name="name">The plan ID.</param>
        /// <param name="publisher">The publisher ID.</param>
        public Plan(string name = default(string), string publisher = default(string))
        {
            Name = name;
            Publisher = publisher;
        }

        /// <summary>
        /// Gets or sets the plan ID.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the publisher ID.
        /// </summary>
        public string Publisher { get; set; }
    }
}
