using commercetools.HistoryApi.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetCustomLineItemTotalPriceChange))]
    public partial interface ISetCustomLineItemTotalPriceChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        ILocalizedString CustomLineItem { get; set; }

        string CustomLineItemId { get; set; }

        IMoney NextValue { get; set; }

        IMoney PreviousValue { get; set; }
    }
}
