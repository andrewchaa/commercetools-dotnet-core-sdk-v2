using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListRemoveTextLineItemAction))]
    public partial interface IMyShoppingListRemoveTextLineItemAction : IMyShoppingListUpdateAction
    {
        string TextLineItemId { get; set; }

        long? Quantity { get; set; }
    }
}
