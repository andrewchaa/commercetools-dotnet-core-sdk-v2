using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.SetPropertyChange))]
    public partial interface ISetPropertyChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string Path { get; set; }

        Object NextValue { get; set; }

        Object PreviousValue { get; set; }
    }
}
