using Calypso.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calypso;
public class CustomerRepository
{
	private ObservableCollection<CustomerModel>	customers;

	public ObservableCollection<CustomerModel> CustomersCollection
	{
		get { return customers; }
		set { customers = value; }
	}

    public CustomerRepository()
    {
        customers = new ObservableCollection<CustomerModel>();
		GenerateDemoCustomers();
    }

    private void GenerateDemoCustomers()
    {
        customers.Add(new CustomerModel() { FirstName = "Nome", LastName = "Cognome", Email = "email@email.com", Phone = "33333333333"});
    }
}
