using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.TrackingData))]
    public partial interface ITrackingData
    {
        string TrackingId { get; set; }

        string Carrier { get; set; }

        string Provider { get; set; }

        string ProviderTransaction { get; set; }

        bool? IsReturn { get; set; }
    }
}
