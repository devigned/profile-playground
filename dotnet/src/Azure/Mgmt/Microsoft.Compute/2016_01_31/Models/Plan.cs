
using System;
using System.Collections.Generic;
using Azure.Mgmt.Compute.Models;

namespace Azure.Mgmt.Compute._2016_01_31.Models
{
    public interface IPlan : Azure.Mgmt.Compute.Models.IPlan {
        string PromotionCode { get; set; }
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
