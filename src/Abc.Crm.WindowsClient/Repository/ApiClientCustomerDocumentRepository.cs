using System.Collections.Generic;
using Abc.Crm.WindowsClient.Interface;
using Abc.Crm.WindowsClient.Models;
using AmagnoWebApi.Client.Api;
using AmagnoWebApi.Client.Client;
using AmagnoWebApi.Client.Model;

namespace Abc.Crm.WindowsClient.Repository
{
    // public class ApiClientCustomerDocumentRepository : ICustomerDocumentRepository
    // {
    //     public IEnumerable<CustomerDocument> GetAll()
    //     {
    //         var tokenApi = new TokenApi();
    //         var documentsApi = new DocumentsApi();
    //         
    //         var token = tokenApi.TokenCreate(new LoginRequest("", ""))
    //             .Trim(trimChar: '"');
    //         
    //         documentsApi.DocumentsInitAdvancedSearch(token, new AdvancedDocumentSearchFilter());
    //     }
    // }
}