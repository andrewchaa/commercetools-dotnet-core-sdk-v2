using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentAddTransactionAction))]
    public partial interface IPaymentAddTransactionAction : IPaymentUpdateAction
    {
        ITransactionDraft Transaction { get; set; }
    }
}
