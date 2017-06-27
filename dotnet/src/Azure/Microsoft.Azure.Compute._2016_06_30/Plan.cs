namespace Microsoft.Azure.Compute
{
    public abstract partial class _2016_06_30
    {
        /// <summary>
        /// Plan for the resource.
        /// </summary>
        public class Plan
        {
            public Plan(string name, string promotionCode = null, string publisher = null)
            {
                PromotionCode = promotionCode;
                Publisher = publisher;
                Name = name;
            }

            public string PromotionCode { get; }

            public string Publisher { get; }

            public string Name { get; }
        }
    }
}
