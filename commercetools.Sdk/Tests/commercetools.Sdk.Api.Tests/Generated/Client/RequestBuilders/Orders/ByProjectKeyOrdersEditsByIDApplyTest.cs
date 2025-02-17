using System;
using System.Collections.Generic;
using System.Net.Http;
using Xunit;

namespace commercetools.Api.Tests.Client.RequestBuilders.Orders
{
    public class ByProjectKeyOrdersEditsByIDApplyTest : RequestBuilderParentTests
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
                   .Orders()
                   .Edits()
                   .WithId("test_ID")
                   .Apply()
                   .Post(null)
                   .Build(),
                   "Post",
                   "/test_projectKey/orders/edits/test_ID/apply",
               }
       };
        }
    }
}
