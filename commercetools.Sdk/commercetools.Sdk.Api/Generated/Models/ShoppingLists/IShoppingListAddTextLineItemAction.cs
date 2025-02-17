using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListAddTextLineItemAction))]
    public partial interface IShoppingListAddTextLineItemAction : IShoppingListUpdateAction
    {
        ILocalizedString Name { get; set; }

        ILocalizedString Description { get; set; }

        long? Quantity { get; set; }

        DateTime? AddedAt { get; set; }

        ICustomFieldsDraft Custom { get; set; }
    }
}
