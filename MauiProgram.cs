namespace NewApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("FontAwesome6FreeBrands.otf", "FontAwesomeBrands");
				fonts.AddFont("FontAwesome6FreeRegular.otf", "FontAwesomeRegular");
				fonts.AddFont("FontAwesome6FreeSolid.otf", "FontAwesomeSolid");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<MainViewModel>();

		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ChoreDetailsDetailViewModel>();
		builder.Services.AddTransient<ChoreDetailsDetailPage>();

		builder.Services.AddSingleton<ChoreDetailsViewModel>();

		builder.Services.AddSingleton<ChoreDetailsPage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ChoresDetailViewModel>();
		builder.Services.AddTransient<ChoresDetailPage>();

		builder.Services.AddSingleton<ChoresViewModel>();

		builder.Services.AddSingleton<ChoresPage>();

		builder.Services.AddSingleton<DrawChoresViewModel>();

		builder.Services.AddSingleton<DrawChoresPage>();

		return builder.Build();
	}
}
