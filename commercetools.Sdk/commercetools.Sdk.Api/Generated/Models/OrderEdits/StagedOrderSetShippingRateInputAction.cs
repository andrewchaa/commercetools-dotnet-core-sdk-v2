using commercetools.Api.Models.Carts;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetShippingRateInputAction : IStagedOrderSetShippingRateInputAction
    {
        public string Action { get; set; }

        public IShippingRateInputDraft ShippingRateInput { get; set; }
        public StagedOrderSetShippingRateInputAction()
        {
            this.Action = "setShippingRateInput";
        }
    }
}
