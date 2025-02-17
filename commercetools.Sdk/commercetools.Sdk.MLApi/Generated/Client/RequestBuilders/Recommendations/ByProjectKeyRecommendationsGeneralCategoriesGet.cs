using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using commercetools.Base.Client;


namespace commercetools.MLApi.Client.RequestBuilders.Recommendations
{
    public partial class ByProjectKeyRecommendationsGeneralCategoriesGet : ApiMethod<ByProjectKeyRecommendationsGeneralCategoriesGet>
    {


        private IClient ApiHttpClient { get; }

        public override HttpMethod Method => HttpMethod.Get;

        private string ProjectKey { get; }


        public ByProjectKeyRecommendationsGeneralCategoriesGet(IClient apiHttpClient, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.ProjectKey = projectKey;
            this.RequestUrl = $"/{ProjectKey}/recommendations/general-categories";
        }

        public List<string> GetProductImageUrl()
        {
            return this.GetQueryParam("productImageUrl");
        }

        public List<string> GetProductName()
        {
            return this.GetQueryParam("productName");
        }

        public List<string> GetLimit()
        {
            return this.GetQueryParam("limit");
        }

        public List<string> GetOffset()
        {
            return this.GetQueryParam("offset");
        }

        public List<string> GetConfidenceMin()
        {
            return this.GetQueryParam("confidenceMin");
        }

        public List<string> GetConfidenceMax()
        {
            return this.GetQueryParam("confidenceMax");
        }

        public ByProjectKeyRecommendationsGeneralCategoriesGet WithProductImageUrl(string productImageUrl)
        {
            return this.AddQueryParam("productImageUrl", productImageUrl);
        }

        public ByProjectKeyRecommendationsGeneralCategoriesGet WithProductName(string productName)
        {
            return this.AddQueryParam("productName", productName);
        }

        public ByProjectKeyRecommendationsGeneralCategoriesGet WithLimit(int limit)
        {
            return this.AddQueryParam("limit", limit.ToString());
        }

        public ByProjectKeyRecommendationsGeneralCategoriesGet WithOffset(int offset)
        {
            return this.AddQueryParam("offset", offset.ToString());
        }

        public ByProjectKeyRecommendationsGeneralCategoriesGet WithConfidenceMin(double confidenceMin)
        {
            return this.AddQueryParam("confidenceMin", confidenceMin.ToString());
        }

        public ByProjectKeyRecommendationsGeneralCategoriesGet WithConfidenceMax(double confidenceMax)
        {
            return this.AddQueryParam("confidenceMax", confidenceMax.ToString());
        }


        public async Task<commercetools.MLApi.Models.GeneralCategoryRecommendations.IGeneralCategoryRecommendationPagedQueryResponse> ExecuteAsync()
        {
            var requestMessage = Build();
            return await ApiHttpClient.ExecuteAsync<commercetools.MLApi.Models.GeneralCategoryRecommendations.IGeneralCategoryRecommendationPagedQueryResponse>(requestMessage);
        }

    }
}
