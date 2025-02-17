using commercetools.MLApi.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.SimilarProducts
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.SimilarProducts.SimilarProductsTaskStatus))]
    public partial interface ISimilarProductsTaskStatus
    {
        ITaskStatusEnum State { get; set; }

        DateTime? Expires { get; set; }

        ISimilarProductsPagedQueryResult Result { get; set; }
    }
}
