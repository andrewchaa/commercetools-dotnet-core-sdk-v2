using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Errors
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Errors.ConcurrentModificationError))]
    public partial interface IConcurrentModificationError : IErrorObject
    {
        long? SpecifiedVersion { get; set; }

        long CurrentVersion { get; set; }

        Object ConflictedResource { get; set; }
    }
}
