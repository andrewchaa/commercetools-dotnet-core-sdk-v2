using commercetools.ImportApi.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Importsinks
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Importsinks.ImportSink))]
    public partial interface IImportSink
    {
        string Key { get; set; }

        IImportResourceType ResourceType { get; set; }

        long Version { get; set; }

        DateTime CreatedAt { get; set; }

        DateTime LastModifiedAt { get; set; }
    }
}
