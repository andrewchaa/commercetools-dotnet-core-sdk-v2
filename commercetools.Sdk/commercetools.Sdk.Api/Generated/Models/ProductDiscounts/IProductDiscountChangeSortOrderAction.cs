using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountChangeSortOrderAction))]
    public partial interface IProductDiscountChangeSortOrderAction : IProductDiscountUpdateAction
    {
        string SortOrder { get; set; }
    }
}
