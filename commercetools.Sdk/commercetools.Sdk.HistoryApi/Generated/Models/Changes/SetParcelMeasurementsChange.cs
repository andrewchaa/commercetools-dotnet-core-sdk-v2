using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Common;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetParcelMeasurementsChange : ISetParcelMeasurementsChange
    {
        public string Type { get; set; }

        public string Change { get; set; }

        public IParcelChangeValue Parcel { get; set; }

        public IParcelMeasurements NextValue { get; set; }

        public IParcelMeasurements PreviousValue { get; set; }
        public SetParcelMeasurementsChange()
        {
            this.Type = "SetParcelMeasurementsChange";
        }
    }
}
