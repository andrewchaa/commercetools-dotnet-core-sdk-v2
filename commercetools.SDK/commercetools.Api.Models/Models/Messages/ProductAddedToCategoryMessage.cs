using commercetools.Api.Models.Categories;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("ProductAddedToCategory")]
    public partial class ProductAddedToCategoryMessage : Message
    {
        public CategoryReference Category { get; set;}
        
        public bool Staged { get; set;}
        public ProductAddedToCategoryMessage()
        { 
           this.Type = "ProductAddedToCategory";
        }
    }
}
