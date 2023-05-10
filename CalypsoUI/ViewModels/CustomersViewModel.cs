using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calypso;
using Calypso.Models;
using LiteDB;

namespace CalypsoUI.ViewModels;
internal class CustomersViewModel
{
    private ObservableCollection<CustomerModel> customers;

    public ObservableCollection<CustomerModel> CustomersCollection
    {
        get { return customers; }
        set { customers = value; }
    }

    public CustomersViewModel()
    {
        customers = new ObservableCollection<CustomerModel>();
        var collection = Application.Current.Handler.MauiContext.Services.GetService<LiteDatabase>().GetCollection<CustomerModel>("customers");
        foreach ( var item in collection.FindAll())
        {
            customers.Add(item);
        }       
    }
}