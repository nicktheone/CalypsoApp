using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Calypso;
using Calypso.Models;
using Calypso.DataAccess;
using LiteDB;

namespace CalypsoUI.ViewModels;
internal class CustomersViewModel
{
    private ObservableCollection<CustomerModel> customers;
    private readonly CustomerRepository customerRepository;

    public ObservableCollection<CustomerModel> CustomersCollection
    {
        get { return customers; }
        set { customers = value; }
    }

    public ICommand NavigateToAddCustomerPageCommand => new Command(NavigateToAddCustomerPage);

    public CustomersViewModel()
    {
        customerRepository = new CustomerRepository(Application.Current.Handler.MauiContext.Services.GetService<LiteDatabase>());
        customers = new ObservableCollection<CustomerModel>();
        var collection = customerRepository.List("customers");
        foreach (var item in collection.FindAll())
        {
            customers.Add(item);
        }
    }

    public async void NavigateToAddCustomerPage()
    {
        await Shell.Current.GoToAsync("addcustomer");
    }
}