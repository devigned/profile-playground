using Azure.Mgmt.Models;
using Azure.Mgmt.Compute._2016_01_31.Models;
using System.Collections.Generic;

namespace Azure.Mgmt.Compute._2016_06_30.Models {

    public interface IPlan {
        string Product { get; set; }
        string PromotionCode { get; set; }
        string Publisher {get; set;}
        string Name {get; set;}
    }

    /// <summary>
    /// Plan for the resource.
    /// </summary>
    public partial class Plan : IPlan
    {
        public Plan(string name, string promotionCode = null, string publisher = null, string product = null) {
            Product = product;
            Publisher = publisher;
            PromotionCode = promotionCode;
        }

        public string PromotionCode { get; set; }
        public string Publisher { get; set; }
        public string Product { get; set; }
        public string Name {get; set;}
    }
}
