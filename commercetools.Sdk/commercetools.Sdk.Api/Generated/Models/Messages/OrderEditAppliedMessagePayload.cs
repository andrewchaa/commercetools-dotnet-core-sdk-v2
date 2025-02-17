using commercetools.Api.Models.OrderEdits;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderEditAppliedMessagePayload : IOrderEditAppliedMessagePayload
    {
        public string Type { get; set; }

        public IOrderEditReference Edit { get; set; }

        public IOrderEditApplied Result { get; set; }
        public OrderEditAppliedMessagePayload()
        {
            this.Type = "OrderEditApplied";
        }
    }
}
