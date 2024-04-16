using DotNet.Meteor.HotReload.Plugin;
using Microsoft.Extensions.Logging;

namespace Inicio;

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
				fonts.AddFont("FontAwesomeBrands-Regular-400.otf", "FAB");
				fonts.AddFont("FontAwesomeFree-Regular-400.otf", "FAF");
				fonts.AddFont("FontAwesomeFree-Solid-900.otf", "FAS");
			});

#if DEBUG
		builder.Logging.AddDebug();
		builder.EnableHotReload();
#endif

		return builder.Build();
	}
}
