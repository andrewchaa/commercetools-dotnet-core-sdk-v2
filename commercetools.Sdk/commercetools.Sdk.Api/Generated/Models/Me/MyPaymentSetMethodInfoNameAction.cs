using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Me
{
    public partial class MyPaymentSetMethodInfoNameAction : IMyPaymentSetMethodInfoNameAction
    {
        public string Action { get; set; }

        public ILocalizedString Name { get; set; }
        public MyPaymentSetMethodInfoNameAction()
        {
            this.Action = "setMethodInfoName";
        }
    }
}
