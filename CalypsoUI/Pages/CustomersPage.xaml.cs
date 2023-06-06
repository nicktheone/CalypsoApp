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
        if (e.Column.MappingName == "Notes")
        {
            e.Column.HeaderText = "Note";
        }
    }

    private void dataGrid_Loaded(object sender, EventArgs e)
    {
        //var height = (10 * dataGrid.RowHeight) + dataGrid.HeaderRowHeight;
        var height = Window.Height - (grid.Height + label.Height) - (dataGrid.Margin.VerticalThickness + vertical.Padding.VerticalThickness + vertical.Spacing);
        dataGrid.HeightRequest = (double)height;
    }
}