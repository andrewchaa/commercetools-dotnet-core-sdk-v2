using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeTaxCalculationModeChange : IChangeTaxCalculationModeChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ITaxCalculationMode PreviousValue { get; set; }

        public ITaxCalculationMode NextValue { get; set; }
        public ChangeTaxCalculationModeChange()
        {
            this.Type = "ChangeTaxCalculationModeChange";
        }
    }
}
