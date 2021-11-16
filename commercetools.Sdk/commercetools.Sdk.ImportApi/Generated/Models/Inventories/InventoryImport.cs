using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Customfields;
using System;


namespace commercetools.ImportApi.Models.Inventories
{
    public partial class InventoryImport : IInventoryImport
    {
        public string Key { get; set; }

        public string Sku { get; set; }

        public double QuantityOnStock { get; set; }

        public double? RestockableInDays { get; set; }

        public DateTime? ExpectedDelivery { get; set; }

        public IChannelKeyReference SupplyChannel { get; set; }

        public ICustom Custom { get; set; }
    }
}
