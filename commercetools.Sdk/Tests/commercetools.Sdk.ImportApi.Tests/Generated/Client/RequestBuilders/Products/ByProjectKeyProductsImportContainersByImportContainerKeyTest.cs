using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.ImportApi.Tests.Client.RequestBuilders.Products
{
    public class ByProjectKeyProductsImportContainersByImportContainerKeyTest : RequestBuilderParentTests
    {
        [Theory]
        [MemberData(nameof(GetData))]
        public void WithMethods(HttpRequestMessage request, string httpMethod, string uri)
        {
            Assert.Equal(httpMethod.ToLower(), request.Method.Method.ToLower());
            Assert.Equal(uri.ToLower(), request.RequestUri.ToString().ToLower());
        }

        public static IEnumerable<object[]> GetData()
        {
            return new List<object[]> {
               new Object[] {
                   ApiRoot
                   .WithProjectKeyValue("test_projectKey")
                   .Products()
                   .ImportContainers()
                   .WithImportContainerKeyValue("test_importContainerKey")
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/products/import-containers/test_importContainerKey",
               }
       };
        }
    }
}
