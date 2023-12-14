namespace Moldovan__Raluca_lab7;

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
			})
		.ConfigureEssentials(essentials =>
         {
             essentials.UseMapServiceToken("cbbcKkCrvmwf08k2KFl5~GSXWtkatxQd5lsoQiHAmow~Avqw9xWkCADYJSNZyixl3I4ARhbRfcpEeoeBwFzjcGC5f-U76zhMDWRRUugB6WbJ");
         });

        return builder.Build();
	}
}
