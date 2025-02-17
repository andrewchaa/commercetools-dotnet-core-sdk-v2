using commercetools.Api.Models.Orders;


namespace commercetools.Api.Models.Messages
{
    public partial class DeliveryAddedMessagePayload : IDeliveryAddedMessagePayload
    {
        public string Type { get; set; }

        public IDelivery Delivery { get; set; }
        public DeliveryAddedMessagePayload()
        {
            this.Type = "DeliveryAdded";
        }
    }
}
