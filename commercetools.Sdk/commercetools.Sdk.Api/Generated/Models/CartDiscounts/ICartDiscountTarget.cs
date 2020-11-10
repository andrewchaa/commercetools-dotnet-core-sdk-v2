using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [SubTypeDiscriminator("multiBuyCustomLineItems", typeof(commercetools.Api.Models.CartDiscounts.MultiBuyCustomLineItemsTarget))]
    [SubTypeDiscriminator("multiBuyLineItems", typeof(commercetools.Api.Models.CartDiscounts.MultiBuyLineItemsTarget))]
    [SubTypeDiscriminator("shipping", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountShippingCostTarget))]
    [SubTypeDiscriminator("lineItems", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountLineItemsTarget))]
    [SubTypeDiscriminator("customLineItems", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountCustomLineItemsTarget))]
    public partial interface ICartDiscountTarget 
    {
        string Type { get; set;}
    }
}
