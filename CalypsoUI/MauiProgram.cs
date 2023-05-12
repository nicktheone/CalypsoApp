using LiteDB;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core;
using Syncfusion.Maui.Core.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace CalypsoUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont(@"Quosm Semi Bold.otf", "Quosm");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.ConfigureSyncfusionCore();
		builder.Services.AddSingleton(serviceProvider =>
			ActivatorUtilities.CreateInstance<LiteDatabase>(serviceProvider, $"{AppContext.BaseDirectory}Database.db"));
        return builder.Build();
	}
}