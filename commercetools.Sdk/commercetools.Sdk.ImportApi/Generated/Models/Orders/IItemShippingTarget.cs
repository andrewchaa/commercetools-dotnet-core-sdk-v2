using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.ItemShippingTarget))]
    public partial interface IItemShippingTarget
    {
        string AddressKey { get; set; }

        double Quantity { get; set; }
    }
}
