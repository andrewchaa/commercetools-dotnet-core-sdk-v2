using commercetools.HistoryApi.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Changes.MoveImageToPositionChange))]
    public partial interface IMoveImageToPositionChange : IChange
    {
        new string Type { get; set; }

        new string Change { get; set; }

        string CatalogData { get; set; }

        List<IImage> PreviousValue { get; set; }

        List<IImage> NextValue { get; set; }
    }
}
