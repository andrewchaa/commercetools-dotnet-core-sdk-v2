using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.HistoryApi.Models.Common.Reservation))]
    public partial interface IReservation
    {
        int Quantity { get; set; }

        IReference Owner { get; set; }

        string CreatedAt { get; set; }

        string CheckoutStartedAt { get; set; }
    }
}
