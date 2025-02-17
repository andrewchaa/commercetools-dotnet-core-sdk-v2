using commercetools.Api.Models.Orders;
using commercetools.Api.Models.States;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DeserializeAs(typeof(commercetools.Api.Models.OrderEdits.StagedOrderTransitionStateAction))]
    public partial interface IStagedOrderTransitionStateAction : IStagedOrderUpdateAction
    {
        IStateResourceIdentifier State { get; set; }

        bool? Force { get; set; }
    }
}
