using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Categories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Categories.CategoryReference))]
    public partial interface ICategoryReference : IReference
    {
        ICategory Obj { get; set; }
    }
}
