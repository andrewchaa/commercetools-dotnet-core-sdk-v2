using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Products
{
    [DeserializeAs(typeof(commercetools.Api.Models.Products.ProductSetSearchKeywordsAction))]
    public partial interface IProductSetSearchKeywordsAction : IProductUpdateAction
    {
        ISearchKeywords SearchKeywords { get; set; }

        bool? Staged { get; set; }
    }
}
