using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductMoveImageToPositionAction))]
    public partial interface IProductMoveImageToPositionAction : IProductUpdateAction
    {
        long? VariantId { get; set; }

        string Sku { get; set; }

        string ImageUrl { get; set; }

        long Position { get; set; }

        bool? Staged { get; set; }
    }
}
