using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderSetOrderNumberAction))]
    public partial interface IOrderSetOrderNumberAction : IOrderUpdateAction
    {
        string OrderNumber { get; set; }
    }
}
