using commercetools.Api.Models.Types;
using System;


namespace commercetools.Api.Models.ShoppingLists
{
    public partial class ShoppingListAddLineItemAction : IShoppingListAddLineItemAction
    {
        public string Action { get; set; }

        public string Sku { get; set; }

        public string ProductId { get; set; }

        public long? VariantId { get; set; }

        public long? Quantity { get; set; }

        public DateTime? AddedAt { get; set; }

        public ICustomFieldsDraft Custom { get; set; }
        public ShoppingListAddLineItemAction()
        {
            this.Action = "addLineItem";
        }
    }
}
