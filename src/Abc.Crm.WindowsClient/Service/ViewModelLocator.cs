/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:Abc.Crm.WindowsClient"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using Abc.Crm.WindowsClient.Interface;
using Abc.Crm.WindowsClient.Repository;
using Abc.Crm.WindowsClient.ViewModel;
using GalaSoft.MvvmLight.Ioc;

namespace Abc.Crm.WindowsClient.Service
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<ICustomerDocumentRepository, DemoCustomerDocumentRepository>();
            //SimpleIoc.Default.Register<ICustomerDocumentRepository, RestSharpCustomerDocumentRepository>();
            SimpleIoc.Default.Register<MainViewModel>();
        }

        public MainViewModel Main
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MainViewModel>();
            }
        }
    }
}