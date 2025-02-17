using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderResourceIdentifier))]
    public partial interface IOrderResourceIdentifier : IResourceIdentifier
    {
    }
}
