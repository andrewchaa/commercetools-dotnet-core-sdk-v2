using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Carts
{
    public partial class CartResourceIdentifier : ICartResourceIdentifier
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public CartResourceIdentifier()
        {
            this.TypeId = IReferenceTypeId.FindEnum("cart");
        }
    }
}
