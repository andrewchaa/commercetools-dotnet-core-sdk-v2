using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Zones
{
    [DeserializeAs(typeof(commercetools.Api.Models.Zones.ZoneReference))]
    public partial interface IZoneReference : IReference
    {
        IZone Obj { get; set; }

        new string Id { get; set; }
    }
}
