using commercetools.Api.Models.Types;
using System;


namespace commercetools.Api.Models.Orders
{
    public partial class LineItemReturnItem : ILineItemReturnItem
    {
        public string Id { get; set; }

        public long Quantity { get; set; }

        public string Type { get; set; }

        public string Comment { get; set; }

        public IReturnShipmentState ShipmentState { get; set; }

        public IReturnPaymentState PaymentState { get; set; }

        public ICustomFields Custom { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public DateTime CreatedAt { get; set; }

        public string LineItemId { get; set; }
        public LineItemReturnItem()
        {
            this.Type = "LineItemReturnItem";
        }
    }
}
