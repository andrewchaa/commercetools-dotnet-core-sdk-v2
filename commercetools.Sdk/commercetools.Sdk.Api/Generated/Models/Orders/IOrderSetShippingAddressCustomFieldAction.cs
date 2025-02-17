using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetShippingAddressCustomFieldAction))]
    public partial interface IOrderSetShippingAddressCustomFieldAction : IOrderUpdateAction
    {
        string Name { get; set; }

        Object Value { get; set; }
    }
}
