using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderAddReturnInfoAction))]
    public partial interface IStagedOrderAddReturnInfoAction : IStagedOrderUpdateAction
    {
        string ReturnTrackingId { get; set; }

        List<IReturnItemDraft> Items { get; set; }

        DateTime? ReturnDate { get; set; }
    }
}
