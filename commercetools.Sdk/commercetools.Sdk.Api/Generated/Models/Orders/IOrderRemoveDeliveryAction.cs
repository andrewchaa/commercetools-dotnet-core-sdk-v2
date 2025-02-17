using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderRemoveDeliveryAction))]
    public partial interface IOrderRemoveDeliveryAction : IOrderUpdateAction
    {
        string DeliveryId { get; set; }
    }
}
