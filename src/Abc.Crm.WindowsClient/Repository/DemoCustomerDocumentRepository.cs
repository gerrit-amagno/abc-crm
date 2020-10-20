using System;
using System.Collections.Generic;
using System.IO;
using Abc.Crm.WindowsClient.Interface;
using Abc.Crm.WindowsClient.Models;

namespace Abc.Crm.WindowsClient.Repository
{
    public class DemoCustomerDocumentRepository : ICustomerDocumentRepository
    {
        private readonly List<CustomerDocument> _customerDocuments = new List<CustomerDocument>();

        public DemoCustomerDocumentRepository()
        {
            _customerDocuments.AddRange(new []
            {
                new CustomerDocument
                {
                    Id = Guid.NewGuid(),
                    Name = "rechnung.pdf",
                    CreateDate = "14.10.2020",
                    ChangeDate = "13.10.2020",
                    DocumentNumber = "R983247",
                    Preview = File.ReadAllBytes("images\\rechnung.pdf.png")
                },
                new CustomerDocument
                {
                    Id = Guid.NewGuid(),
                    Name = "lieferschein.pdf",
                    CreateDate = "20.10.2020",
                    ChangeDate = "19.10.2020",
                    DocumentNumber = "L304802",
                    Preview = File.ReadAllBytes("images\\lieferschein.pdf.png")
                }
            });
        }

        public IEnumerable<CustomerDocument> GetAll()
        {
            return _customerDocuments;
        }
    }
}