using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.ImportApi.Client.RequestBuilders.ImportSinks
{
    public partial class ByProjectKeyImportSinksByImportSinkKeyDelete : ApiMethod<ByProjectKeyImportSinksByImportSinkKeyDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ImportSinkKey { get; }


        public ByProjectKeyImportSinksByImportSinkKeyDelete(IClient apiHttpClient, string projectKey, string importSinkKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ImportSinkKey = importSinkKey;
            this.RequestUrl = $"/{ProjectKey}/import-sinks/{ImportSinkKey}";
        }




        public async Task<commercetools.ImportApi.Models.Importsinks.IImportSink> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.ImportApi.Models.Importsinks.IImportSink>(requestMessage);
        }

    }
}
