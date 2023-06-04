using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calypso.Models;

namespace CalypsoUI.ViewModels;
internal class AddCustomerPageViewModel
{
    public CustomerModel Customer { get; set; }

    public AddCustomerPageViewModel()
    {
        Customer = new CustomerModel();
    }
}
