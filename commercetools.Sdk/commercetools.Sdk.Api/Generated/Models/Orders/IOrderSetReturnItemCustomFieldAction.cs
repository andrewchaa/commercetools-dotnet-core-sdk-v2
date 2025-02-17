using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetReturnItemCustomFieldAction))]
    public partial interface IOrderSetReturnItemCustomFieldAction : IOrderUpdateAction
    {
        string ReturnItemId { get; set; }

        string Name { get; set; }

        Object Value { get; set; }
    }
}
