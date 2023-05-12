using CalypsoUI.Pages;
using Microsoft.Maui.Controls;

namespace CalypsoUI;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute("addcustomer", typeof(AddCustomerPage));
	}
}
