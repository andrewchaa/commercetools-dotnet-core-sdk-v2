using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.ContainerAndKey))]
    public partial interface IContainerAndKey
    {
        string Key { get; set; }

        string Container { get; set; }
    }
}
