using commercetools.Api.Models.States;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Api.Models.Orders.OrderTransitionStateAction))]
    public partial interface IOrderTransitionStateAction : IOrderUpdateAction
    {
        IStateResourceIdentifier State { get; set; }

        bool? Force { get; set; }
    }
}
