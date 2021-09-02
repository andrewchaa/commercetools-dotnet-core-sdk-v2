using commercetools.HistoryApi.Models.ChangeValues;
using commercetools.HistoryApi.Models.Changes;
using commercetools.HistoryApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.HistoryApi.Models.Changes
{
    public partial class SetAssetCustomTypeChange : ISetAssetCustomTypeChange
    {
        public string Type { get; set;}
        
        public string Change { get; set;}
        
        public IAssetChangeValue Asset { get; set;}
        
        public ICustomFields NextValue { get; set;}
        
        public ICustomFields PreviousValue { get; set;}
        public SetAssetCustomTypeChange()
        { 
           this.Type = "SetAssetCustomTypeChange";
        }
    }
}
