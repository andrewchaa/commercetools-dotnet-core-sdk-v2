using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartChangeLineItemQuantityAction))]
    public partial interface IMyCartChangeLineItemQuantityAction : IMyCartUpdateAction
    {
        string LineItemId { get; set; }

        long Quantity { get; set; }

        IMoney ExternalPrice { get; set; }

        IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }
    }
}
