using Microsoft.Extensions.Logging;

namespace VoiceBookMAUI
{
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
					fonts.AddFont("fontello.ttf", "Fontello");
					fonts.AddFont("Bison.ttf", "Bison");
					fonts.AddFont("fontawesome-webfont.ttf", "FontAwesome");
					fonts.AddFont("fontAwesome.ttf", "FontAwesomeSolid");
					fonts.AddFont("Epilogue-Medium.ttf", "Epilogue");
					fonts.AddFont("SpaceGrotesk-Bold.ttf", "SpaceGB");
					fonts.AddFont("SpaceGrotesk-Medium.ttf", "SpaceGM");
					fonts.AddFont("SpaceGrotesk-Regular.ttf", "SpaceGR");
					fonts.AddFont("SpaceGrotesk-SemiBold.ttf", "SpaceGSB");
					fonts.AddFont("SpaceMono-Bold.ttf", "SpaceMB");
					fonts.AddFont("SpaceMono-Regular.ttf", "SpaceMR");
					fonts.AddFont("Roboto-Light.ttf", "RobotoL");
					fonts.AddFont("Roboto-Regular.ttf", "RobotoR");

				});

#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}
	}
}
