using Abc.Crm.WindowsClient.Models;
using GalaSoft.MvvmLight;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using Abc.Crm.WindowsClient.Interface;
using Abc.Crm.WindowsClient.Properties;

namespace Abc.Crm.WindowsClient.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private Customer _selectedCustomer;
        private CustomerDocument _selectedDocument;
        private ObservableCollection<CustomerDocument> _documentList;
        private readonly ICustomerDocumentRepository _documentRepository;

        public string Title => $"Kunde - {SelectedCustomer.Name} ({SelectedCustomer.Number})";

        public Customer SelectedCustomer { get => _selectedCustomer; set => Set(ref _selectedCustomer, value); }

        public ObservableCollection<CustomerDocument> DocumentList { get => _documentList; set => Set(ref _documentList, value); }

        public CustomerDocument SelectedDocument { get => _selectedDocument; set => Set(ref _selectedDocument, value); }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(ICustomerDocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;

            Init();
        }

        private void Init()
        {
            SelectedCustomer = new Customer
            {
                Address = "Küstenstraße 15",
                Country = "Deutschland",
                City = "Wilhelmshaven",
                Name = "Windpark Borkum GmbH",
                Number = "1030",
                Postcode = "26382",
                Logo = File.ReadAllBytes(@"images\windpark-logo.png")
            };

            DocumentList = new ObservableCollection<CustomerDocument>(_documentRepository.GetAll());

            SelectedDocument = DocumentList.First();
        }
    }
}