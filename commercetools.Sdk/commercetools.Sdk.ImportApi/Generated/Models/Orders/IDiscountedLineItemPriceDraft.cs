using commercetools.ImportApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.DiscountedLineItemPriceDraft))]
    public partial interface IDiscountedLineItemPriceDraft
    {
        IMoney Value { get; set; }

        List<IDiscountedLineItemPortion> IncludedDiscounts { get; set; }
    }
}
