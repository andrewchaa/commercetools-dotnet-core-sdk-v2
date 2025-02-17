using commercetools.Base.Client;
using commercetools.Base.Serialization;

namespace commercetools.Api.Client.RequestBuilders.Customers
{

    public class ByProjectKeyCustomersPasswordResetRequestBuilder
    {

        private IClient ApiHttpClient { get; }

        private ISerializerService SerializerService { get; }

        private string ProjectKey { get; }

        public ByProjectKeyCustomersPasswordResetRequestBuilder(IClient apiHttpClient, ISerializerService serializerService, string projectKey)
        {
            this.ApiHttpClient = apiHttpClient;
            this.SerializerService = serializerService;
            this.ProjectKey = projectKey;
        }

        public ByProjectKeyCustomersPasswordResetPost Post(commercetools.Api.Models.Customers.ICustomerResetPassword customerResetPassword)
        {
            return new ByProjectKeyCustomersPasswordResetPost(ApiHttpClient, SerializerService, ProjectKey, customerResetPassword);
        }

    }
}
