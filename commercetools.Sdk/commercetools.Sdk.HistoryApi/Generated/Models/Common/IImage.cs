using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.Image))]
    public partial interface IImage
    {
        string Url { get; set; }

        IImageDimensions Dimensions { get; set; }

        string Label { get; set; }
    }
}
