using Azure.Mgmt.Models;
using System.Collections.Generic;

namespace Azure.Mgmt.Compute.Models
{
    public interface IPlan {
        string Publisher {get; set;}
        string Name {get; set;}
    }
}
