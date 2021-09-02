using commercetools.MLApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.ImageSearches
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.ImageSearches.ResultItem))]
    public partial interface IResultItem 
    {
        string ImageUrl { get; set;}
        
        List<IProductVariant> ProductVariants { get; set;}
    }
}
