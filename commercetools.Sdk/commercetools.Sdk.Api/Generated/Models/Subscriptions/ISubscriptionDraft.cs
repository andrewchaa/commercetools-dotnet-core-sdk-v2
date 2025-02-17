using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Subscriptions
{
    [DeserializeAs(typeof(commercetools.Api.Models.Subscriptions.SubscriptionDraft))]
    public partial interface ISubscriptionDraft
    {
        List<IChangeSubscription> Changes { get; set; }

        IDestination Destination { get; set; }

        string Key { get; set; }

        List<IMessageSubscription> Messages { get; set; }

        IDeliveryFormat Format { get; set; }
    }
}
