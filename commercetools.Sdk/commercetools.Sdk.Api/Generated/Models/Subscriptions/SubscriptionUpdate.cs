using System.Collections.Generic;


namespace commercetools.Api.Models.Subscriptions
{
    public partial class SubscriptionUpdate : ISubscriptionUpdate
    {
        public long Version { get; set; }

        public List<ISubscriptionUpdateAction> Actions { get; set; }
    }
}
