using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.FeatureRemovedError))]
    public partial interface IFeatureRemovedError : IErrorObject
    {
    }
}
