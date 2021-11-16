using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.MLApi.Tests.Client.RequestBuilders.MissingData
{
    public class ByProjectKeyMissingDataAttributesTest : RequestBuilderParentTests
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
                   .WithProjectKey("test_projectKey")
                   .MissingData()
                   .Attributes()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/missing-data/attributes",
               }
       };
        }
    }
}
