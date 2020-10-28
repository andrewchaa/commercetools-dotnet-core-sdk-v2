using commercetools.Api.Models.Projects;
using commercetools.Api.Models.ShippingMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Projects
{
    public partial class CartScoreType : ICartScoreType
    {
        public string Type { get; set;}
        
        [JsonIgnore]
        public ShippingRateTierType TypeAsEnum => this.Type.GetEnum<ShippingRateTierType>();
        public CartScoreType()
        { 
           this.Type = "CartScore";
        }
    }
}
