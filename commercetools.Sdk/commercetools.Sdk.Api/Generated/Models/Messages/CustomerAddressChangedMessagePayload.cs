using commercetools.Api.Models.Common;


namespace commercetools.Api.Models.Messages
{
    public partial class CustomerAddressChangedMessagePayload : ICustomerAddressChangedMessagePayload
    {
        public string Type { get; set; }

        public IAddress Address { get; set; }
        public CustomerAddressChangedMessagePayload()
        {
            this.Type = "CustomerAddressChanged";
        }
    }
}
