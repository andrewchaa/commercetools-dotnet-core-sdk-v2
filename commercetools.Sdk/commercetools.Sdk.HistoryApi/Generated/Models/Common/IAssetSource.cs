using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.AssetSource))]
    public partial interface IAssetSource
    {
        string Uri { get; set; }

        string Key { get; set; }

        IAssetDimensions Dimensions { get; set; }

        string ContentType { get; set; }
    }
}
