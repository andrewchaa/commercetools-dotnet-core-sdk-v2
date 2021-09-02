using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importsinks
{
    public partial class ImportSink : IImportSink
    {
        public string Key { get; set;}
        
        public IImportResourceType ResourceType { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
    }
}
