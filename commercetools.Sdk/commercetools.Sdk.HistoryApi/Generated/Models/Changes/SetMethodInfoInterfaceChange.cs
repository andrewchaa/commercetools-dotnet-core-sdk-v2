namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetMethodInfoInterfaceChange : ISetMethodInfoInterfaceChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public string PreviousValue { get; set; }

        public string NextValue { get; set; }
        public SetMethodInfoInterfaceChange()
        {
            this.Type = "SetMethodInfoInterfaceChange";
        }
    }
}
