using commercetools.Api.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ProductDiscounts
{
    [DeserializeAs(typeof(commercetools.Api.Models.ProductDiscounts.ProductDiscountDraft))]
    public partial interface IProductDiscountDraft
    {
        ILocalizedString Name { get; set; }

        string Key { get; set; }

        ILocalizedString Description { get; set; }

        IProductDiscountValueDraft Value { get; set; }

        string Predicate { get; set; }

        string SortOrder { get; set; }

        bool IsActive { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }
    }
}
