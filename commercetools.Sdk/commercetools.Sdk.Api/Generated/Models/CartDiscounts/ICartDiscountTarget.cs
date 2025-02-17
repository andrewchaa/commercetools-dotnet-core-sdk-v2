using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [TypeDiscriminator(nameof(Type))]
    [DefaultTypeDiscriminator(typeof(commercetools.Api.Models.CartDiscounts.CartDiscountTarget))]
    [SubTypeDiscriminator("customLineItems", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountCustomLineItemsTarget))]
    [SubTypeDiscriminator("lineItems", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountLineItemsTarget))]
    [SubTypeDiscriminator("multiBuyCustomLineItems", typeof(commercetools.Api.Models.CartDiscounts.MultiBuyCustomLineItemsTarget))]
    [SubTypeDiscriminator("multiBuyLineItems", typeof(commercetools.Api.Models.CartDiscounts.MultiBuyLineItemsTarget))]
    [SubTypeDiscriminator("shipping", typeof(commercetools.Api.Models.CartDiscounts.CartDiscountShippingCostTarget))]
    public partial interface ICartDiscountTarget
    {
        string Type { get; set; }
    }
}
