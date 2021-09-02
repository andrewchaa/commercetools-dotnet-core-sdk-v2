using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public partial class DeliveryAddedMessagePayload : IDeliveryAddedMessagePayload
    {
        public string Type { get; set;}
        
        public IDelivery Delivery { get; set;}
        public DeliveryAddedMessagePayload()
        { 
           this.Type = "DeliveryAdded";
        }
    }
}
