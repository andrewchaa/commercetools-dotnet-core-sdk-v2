using commercetools.Api.Models.Common;
using commercetools.Api.Models.Orders;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderSetShippingAddressAction))]
    public partial interface IStagedOrderSetShippingAddressAction : IStagedOrderUpdateAction
    {
        IBaseAddress Address { get; set; }
    }
}
