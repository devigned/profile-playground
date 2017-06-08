
namespace Azure.Mgmt.Compute._2016_06_30.Models
{
    /// <summary>
    /// Plan for the resource.
    /// </summary>
    public partial class Plan : Azure.Mgmt.Compute._2016_01_31.Models.Plan
    {
        /// <summary>
        /// Initializes a new instance of the Plan class.
        /// </summary>
        public Plan() { }

        /// <summary>
        /// Initializes a new instance of the Plan class.
        /// </summary>
        /// <param name="product">The offer ID.</param>
        public Plan(string product = default(string))
        {
            Product = product;
        }

        /// <summary>
        /// Gets or sets the offer ID.
        /// </summary>
        public string Product { get; set; }
    }
}
