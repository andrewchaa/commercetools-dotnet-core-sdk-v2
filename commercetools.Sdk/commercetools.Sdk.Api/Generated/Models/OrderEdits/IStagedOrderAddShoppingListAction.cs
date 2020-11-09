using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.ShoppingLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderAddShoppingListAction))]
    public partial interface IStagedOrderAddShoppingListAction : IStagedOrderUpdateAction
    {
        IShoppingListResourceIdentifier ShoppingList { get; set;}
        
        IChannelResourceIdentifier SupplyChannel { get; set;}
        
        IChannelResourceIdentifier DistributionChannel { get; set;}
    }
}
