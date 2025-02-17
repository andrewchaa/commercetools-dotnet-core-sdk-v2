using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetCustomLineItemTaxAmountChange : ISetCustomLineItemTaxAmountChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString CustomLineItem { get; set; }

        public string CustomLineItemId { get; set; }

        public ITaxMode TaxMode { get; set; }

        public ITaxRate NextValue { get; set; }

        public ITaxRate PreviousValue { get; set; }
        public SetCustomLineItemTaxAmountChange()
        {
            this.Type = "SetCustomLineItemTaxAmountChange";
        }
    }
}
