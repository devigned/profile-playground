
namespace Azure.Mgmt.Compute._2016_01_31.Models
{
    /// <summary>
    /// Plan for the resource.
    /// </summary>
    public partial class Plan : Azure.Mgmt.Compute.Models.Plan
    {
        /// <summary>
        /// Initializes a new instance of the Plan class.
        /// </summary>
        public Plan() { }

        /// <summary>
        /// Initializes a new instance of the Plan class.
        /// </summary>
        /// <param name="promotionCode">The promotion code.</param>
        public Plan(string promotionCode = default(string))
        {
            PromotionCode = promotionCode;
        }

        /// <summary>
        /// Gets or sets the promotion code.
        /// </summary>
        public string PromotionCode { get; set; }

    }
}
