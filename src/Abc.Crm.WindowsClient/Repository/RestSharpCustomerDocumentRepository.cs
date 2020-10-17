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
            throw new NotImplementedException();

            // return response.Content.Trim(trimChar: '"');
        }

        private string GetSearchLocation(string token)
        {
            throw new NotImplementedException();

            // return GetLocation(response);
        }

        private List<CustomerDocument> GetSearchResults(string token, string location)
        {
            throw new NotImplementedException();

            // return client.Execute<List<CustomerDocument>>(request).Data;
        }

        private byte[] GetPreview(string token, Guid documentId)
        {
            throw new NotImplementedException();

            // return response.RawBytes;
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