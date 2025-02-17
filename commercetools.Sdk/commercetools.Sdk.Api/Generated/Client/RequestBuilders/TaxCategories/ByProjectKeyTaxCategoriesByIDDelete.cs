using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.Api.Client.RequestBuilders.TaxCategories
{
    public partial class ByProjectKeyTaxCategoriesByIDDelete : ApiMethod<ByProjectKeyTaxCategoriesByIDDelete>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Delete;

        private string ProjectKey { get; }

        private string ID { get; }


        public ByProjectKeyTaxCategoriesByIDDelete(IClient apiHttpClient, string projectKey, string id)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.ID = id;
            this.RequestUrl = $"/{ProjectKey}/tax-categories/{ID}";
        }

        public List<string> GetVersion()
        {
            return this.GetQueryParam("version");
        }

        public List<string> GetExpand()
        {
            return this.GetQueryParam("expand");
        }

        public ByProjectKeyTaxCategoriesByIDDelete WithVersion(long version)
        {
            return this.AddQueryParam("version", version.ToString());
        }

        public ByProjectKeyTaxCategoriesByIDDelete WithExpand(string expand)
        {
            return this.AddQueryParam("expand", expand);
        }


        public async Task<commercetools.Api.Models.TaxCategories.ITaxCategory> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.Api.Models.TaxCategories.ITaxCategory>(requestMessage);
        }

    }
}
