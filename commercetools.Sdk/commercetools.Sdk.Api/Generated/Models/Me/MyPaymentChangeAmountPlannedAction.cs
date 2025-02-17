using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Me
{
    public partial class MyPaymentChangeAmountPlannedAction : IMyPaymentChangeAmountPlannedAction
    {
        public string Action { get; set; }

        public IMoney Amount { get; set; }
        public MyPaymentChangeAmountPlannedAction()
        {
            this.Action = "changeAmountPlanned";
        }
    }
}
