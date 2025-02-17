using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class RemoveCustomLineItemChange : IRemoveCustomLineItemChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ICustomLineItem NextValue { get; set; }

        public ICustomLineItem PreviousValue { get; set; }
        public RemoveCustomLineItemChange()
        {
            this.Type = "RemoveCustomLineItemChange";
        }
    }
}
