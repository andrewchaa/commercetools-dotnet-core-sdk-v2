using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.ImportApi.Client.RequestBuilders.ImportContainers
{
    public partial class ByProjectKeyImportContainersByImportContainerKeyPut : ApiMethod<ByProjectKeyImportContainersByImportContainerKeyPut>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Put;

        private string ProjectKey { get; }

        private string ImportContainerKey { get; }

        private commercetools.ImportApi.Models.Importcontainers.IImportContainerUpdateDraft ImportContainerUpdateDraft;

        public ByProjectKeyImportContainersByImportContainerKeyPut(IClient apiHttpClient, string projectKey, string importContainerKey, commercetools.ImportApi.Models.Importcontainers.IImportContainerUpdateDraft importContainerUpdateDraft)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ImportContainerKey = importContainerKey;
            this.ImportContainerUpdateDraft = importContainerUpdateDraft;
            this.RequestUrl = $"/{ProjectKey}/import-containers/{ImportContainerKey}";
        }




        public async Task<commercetools.ImportApi.Models.Importcontainers.IImportContainer> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.ImportApi.Models.Importcontainers.IImportContainer>(requestMessage);
        }

    }
}
