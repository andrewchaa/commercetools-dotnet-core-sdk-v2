using commercetools.Api.Models.Carts;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderChangeTaxCalculationModeAction : IStagedOrderChangeTaxCalculationModeAction
    {
        public string Action { get; set; }

        public ITaxCalculationMode TaxCalculationMode { get; set; }
        public StagedOrderChangeTaxCalculationModeAction()
        {
            this.Action = "changeTaxCalculationMode";
        }
    }
}
