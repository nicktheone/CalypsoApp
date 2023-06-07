using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Calypso.DataAccess;
using Calypso.Models;
using LiteDB;

namespace CalypsoUI.ViewModels;
internal class AddCustomerPageViewModel
{
    public CustomerModel Customer { get; set; }
    private readonly CustomerRepository customerRepository;
    public ICommand AddClientCommand => new Command(AddClient);

    public AddCustomerPageViewModel()
    {
        Customer = new CustomerModel();
        customerRepository = new CustomerRepository(Application.Current.Handler.MauiContext.Services.GetService<LiteDatabase>());
    }
    public async void AddClient()
    {
        customerRepository.Add("customers", Customer);

        Customer = new CustomerModel();
    }

}
