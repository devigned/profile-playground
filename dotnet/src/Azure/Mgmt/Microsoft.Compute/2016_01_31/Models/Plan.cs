
using System;
using System.Collections.Generic;

namespace Azure.Mgmt.Compute._2016_01_31.Models
{
    public interface IPlan {
        string PromotionCode { get; set; }
        string Publisher {get; set;}
        string Name {get; set;}
    }

    /// <summary>
    /// Plan for the resource.
    /// </summary>
    public partial class Plan : IPlan
    {
        public Plan(string name, string promotionCode = null, string publisher = null) {
            PromotionCode = promotionCode;
            Publisher = publisher;
            Name = name;
        }
        public string PromotionCode { get; set; }
        public string Publisher { get; set; }

        public string Name {get; set;}
    }
}
