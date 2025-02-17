using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class AddAttributeDefinitionChange : IAddAttributeDefinitionChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IAttributeDefinition NextValue { get; set; }
        public AddAttributeDefinitionChange()
        {
            this.Type = "AddAttributeDefinitionChange";
        }
    }
}
