namespace CalypsoUI;
public partial class App : Application
{
    public App()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTc4OTcyNkAzMjMxMmUzMTJlMzMzNWpyeVFMUUh4Zm1nTzltak5nczlMYStBbVBMTnhMdDNxejBvV1BwNVY1SzA9");

		InitializeComponent();

		MainPage = new AppShell();
	}
}
