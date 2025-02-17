using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductSelections
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductSelections.ProductSelectionDraft))]
    public partial interface IProductSelectionDraft
    {
        string Key { get; set; }

        ILocalizedString Name { get; set; }
    }
}
