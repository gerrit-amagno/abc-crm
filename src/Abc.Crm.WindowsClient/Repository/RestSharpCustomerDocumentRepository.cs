using System;
using System.Collections.Generic;
using System.Linq;
using Abc.Crm.WindowsClient.Interface;
using Abc.Crm.WindowsClient.Models;
using RestSharp;

namespace Abc.Crm.WindowsClient.Repository
{
    public class RestSharpCustomerDocumentRepository : ICustomerDocumentRepository
    {
        public IEnumerable<CustomerDocument> GetAll()
        {
            var token = GetToken();
            var location = GetSearchLocation(token);
            var documents = GetSearchResults(token, location);

            foreach (var document in documents)
            {
                document.Preview = GetPreview(token, document.Id);
                document.DocumentNumber = FormatLong(document.DocumentNumber);
                document.ChangeDate = FormatDateTime(document.ChangeDate);
                document.CreateDate = FormatDateTime(document.CreateDate);
            }

            return documents;
        }

        private string GetToken()
        {
            var client = new RestClient("http://localhost/amagnome/api/v2/token");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("userName", "ged@amagno.de");
            request.AddParameter("password", "hannes");
            IRestResponse response = client.Execute(request);

            return response.Content.Trim(trimChar: '"');
        }

        private string GetSearchLocation(string token)
        {
            var customerNumber = "1030";
            var tagDefinitionId = "d4bcf9a0-5f0d-eb11-a7a2-70bc1078686b";
            var vaultId = "d4bcf9a0-5f0d-eb11-a7a2-70bc1078686b";

            var client = new RestClient("http://localhost/amagnome/api/v2/documents/advanced-search");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", $"Bearer {token}");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", "{\r\n  \"condition\": {\r\n    \"type\": \"StringEqualsCondition\",\r\n   "
                + $" \"Value\" : \"{customerNumber}\",\r\n    \"TagDefinitionIds\" : [ \"{tagDefinitionId}\" ]\r\n  }},\r\n  "
                + $"\"vaultIds\": [\r\n    \"{vaultId}\"\r\n  ]\r\n"
                + "}",  ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            return GetLocation(response);
        }

        private List<CustomerDocument> GetSearchResults(string token, string location)
        {
            var client = new RestClient($"http://localhost/amagnome/api/v2/{location}/results");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"Bearer {token}");

            return client.Execute<List<CustomerDocument>>(request).Data;
        }

        private byte[] GetPreview(string token, Guid documentId)
        {
            var client = new RestClient($"http://localhost/amagnome/api/v2/documents/{documentId}/preview?page=1&size=Large");
            var request = new RestRequest(Method.GET);
            request.AddHeader("Authorization", $"Bearer {token}");
            IRestResponse response = client.Execute(request);

            return response.RawBytes;
        }

        #region Helper Methods

        private static string GetLocation(IRestResponse response)
        {
            var value = response.Headers.SingleOrDefault(i => i.Name == "Location")?.Value;
            if (value != null)
            {
                return value.ToString();
            }

            return string.Empty;
        }

        private static string FormatLong(string value)
        {
            return (Convert.ToInt32(value) / 10000).ToString();
        }

        private static string FormatDateTime(string value)
        {
            var changeDate = DateTime.Parse(value);
            return $"{changeDate.ToLongDateString()} {changeDate.ToLongTimeString()}";
        }

        #endregion
    }
}