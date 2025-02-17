using commercetools.Api.Models.Products;


namespace commercetools.Api.Models.Messages
{
    public partial class ProductSelectionProductAddedMessagePayload : IProductSelectionProductAddedMessagePayload
    {
        public string Type { get; set; }

        public IProductReference Product { get; set; }
        public ProductSelectionProductAddedMessagePayload()
        {
            this.Type = "ProductSelectionProductAdded";
        }
    }
}
