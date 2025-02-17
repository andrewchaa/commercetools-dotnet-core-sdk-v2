using commercetools.Base.CustomAttributes;


namespace commercetools.MLApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.MLApi.Models.Common.TaskToken))]
    public partial interface ITaskToken
    {
        string TaskId { get; set; }

        string UriPath { get; set; }
    }
}
