using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    public partial class StoreRemoveSupplyChannelAction : IStoreRemoveSupplyChannelAction
    {
        public string Action { get; set;}
        
        public IChannelResourceIdentifier SupplyChannel { get; set;}
        public StoreRemoveSupplyChannelAction()
        { 
           this.Action = "removeSupplyChannel";
        }
    }
}
