using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.MissingData
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.MissingData.MissingAttributesPagedQueryResult))]
    public partial interface IMissingAttributesPagedQueryResult
    {
        long Count { get; set; }

        long Total { get; set; }

        long Offset { get; set; }

        List<IMissingAttributes> Results { get; set; }

        IMissingAttributesMeta Meta { get; set; }
    }
}
