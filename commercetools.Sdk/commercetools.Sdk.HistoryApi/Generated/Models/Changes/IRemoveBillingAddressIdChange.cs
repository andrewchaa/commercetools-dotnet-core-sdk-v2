using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.RemoveBillingAddressIdChange))]
    public partial interface IRemoveBillingAddressIdChange : IChange
    {
        new string Change { get; set; }

        new string Type { get; set; }

        List<string> NextValue { get; set; }

        List<string> PreviousValue { get; set; }

        IAddress Address { get; set; }
    }
}
