using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.Variant))]
    public partial interface IVariant
    {
        int Id { get; set; }

        string Sku { get; set; }

        string Key { get; set; }
    }
}
