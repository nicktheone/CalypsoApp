using Syncfusion.Maui.DataGrid;
using System.Windows.Input;

namespace CalypsoUI.Pages;

public partial class CustomersPage : ContentPage
{
	public CustomersPage()
	{
		InitializeComponent();
	}

    private void dataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
    {
        // Cancels the creation of the "Id" column
        if (e.Column.MappingName == "Id")
        {
            e.Cancel = true;
        }

        if (e.Column.MappingName == "FirstName")
        {
            e.Column.HeaderText = "Nome";
        }
        if (e.Column.MappingName == "LastName")
        {
            e.Column.HeaderText = "Cognome";
        }
        if (e.Column.MappingName == "Phone")
        {
            e.Column.HeaderText = "Telefono";
        }
    }
}