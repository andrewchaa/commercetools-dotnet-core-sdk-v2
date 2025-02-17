using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Api.Models.Carts.CartReference))]
    public partial interface ICartReference : IReference
    {
        ICart Obj { get; set; }
    }
}
