namespace commercetools.ImportApi.Models.Common
{
    public partial class LocalizedEnumValue : ILocalizedEnumValue
    {
        public string Key { get; set; }

        public ILocalizedString Label { get; set; }
    }
}
