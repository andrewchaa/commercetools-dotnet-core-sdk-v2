using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class ChangeLocalizedNameChange : IChangeLocalizedNameChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public ILocalizedString PreviousValue { get; set; }

        public ILocalizedString NextValue { get; set; }
        public ChangeLocalizedNameChange()
        {
            this.Type = "ChangeLocalizedNameChange";
        }
    }
}
