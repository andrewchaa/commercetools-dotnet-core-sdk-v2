using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductTypes
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductTypes.ProductTypeChangeEnumKeyAction))]
    public partial interface IProductTypeChangeEnumKeyAction : IProductTypeUpdateAction
    {
        string AttributeName { get; set; }

        string Key { get; set; }

        string NewKey { get; set; }
    }
}
