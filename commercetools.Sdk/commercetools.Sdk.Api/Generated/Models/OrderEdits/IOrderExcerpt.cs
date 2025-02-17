using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.OrderExcerpt))]
    public partial interface IOrderExcerpt
    {
        ITypedMoney TotalPrice { get; set; }

        ITaxedPrice TaxedPrice { get; set; }

        int Version { get; set; }
    }
}
