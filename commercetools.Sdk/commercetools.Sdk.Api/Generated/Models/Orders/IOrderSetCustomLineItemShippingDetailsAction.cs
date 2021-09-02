using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetCustomLineItemShippingDetailsAction))]
    public partial interface IOrderSetCustomLineItemShippingDetailsAction : IOrderUpdateAction
    {
        string CustomLineItemId { get; set;}
        
        IItemShippingDetailsDraft ShippingDetails { get; set;}
    }
}
