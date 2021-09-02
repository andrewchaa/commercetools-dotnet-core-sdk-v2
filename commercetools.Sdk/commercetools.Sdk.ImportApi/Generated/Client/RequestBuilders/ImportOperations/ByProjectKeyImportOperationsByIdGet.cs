using System;
using System.IO;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using commercetools.Base.Client;
using commercetools.Base.Serialization;


namespace commercetools.ImportApi.Client.RequestBuilders.ImportOperations
{
   public partial class ByProjectKeyImportOperationsByIdGet : ApiMethod<ByProjectKeyImportOperationsByIdGet> {

       
       private IClient ApiHttpClient { get; }
       
       public override HttpMethod Method => HttpMethod.Get;
       
       private string ProjectKey { get; }
       
       private string Id { get; }
       
   
       public ByProjectKeyImportOperationsByIdGet(IClient apiHttpClient, string projectKey, string id) {
           this.ApiHttpClient = apiHttpClient;
           this.ProjectKey = projectKey;
           this.Id = id;
           this.RequestUrl = $"/{ProjectKey}/import-operations/{Id}";
       }
   
   
       

       public async Task<commercetools.ImportApi.Models.Importoperations.IImportOperation> ExecuteAsync()
       {
          var requestMessage = Build();
          return await ApiHttpClient.ExecuteAsync<commercetools.ImportApi.Models.Importoperations.IImportOperation>(requestMessage);
       }
   }
}
