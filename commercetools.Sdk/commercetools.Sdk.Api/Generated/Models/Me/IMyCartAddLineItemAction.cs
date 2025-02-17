using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyCartAddLineItemAction))]
    public partial interface IMyCartAddLineItemAction : IMyCartUpdateAction
    {
        ICustomFieldsDraft Custom { get; set; }

        IChannelResourceIdentifier DistributionChannel { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

        string ProductId { get; set; }

        long? VariantId { get; set; }

        string Sku { get; set; }

        long? Quantity { get; set; }

        IChannelResourceIdentifier SupplyChannel { get; set; }

        IMoney ExternalPrice { get; set; }

        IExternalLineItemTotalPrice ExternalTotalPrice { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

        DateTime? AddedAt { get; set; }
    }
}
