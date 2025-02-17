using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.ExternalLineItemTotalPrice))]
    public partial interface IExternalLineItemTotalPrice
    {
        IMoney Price { get; set; }

        IMoney TotalPrice { get; set; }
    }
}
