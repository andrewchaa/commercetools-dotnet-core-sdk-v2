using System;


namespace commercetools.Api.Models.DiscountCodes
{
    public partial class DiscountCodeSetValidUntilAction : IDiscountCodeSetValidUntilAction
    {
        public string Action { get; set; }

        public DateTime? ValidUntil { get; set; }
        public DiscountCodeSetValidUntilAction()
        {
            this.Action = "setValidUntil";
        }
    }
}
