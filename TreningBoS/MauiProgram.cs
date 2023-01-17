using Microsoft.Extensions.Logging;
using TreningBoS.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using TreningBoS.Factories.ElementFactories;
using TreningBoS.Services;
using TreningBoS.ViewModel.Components.MainPage;
using TreningBoS.View.Components.MainPage;

namespace TreningBoS;

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
			});


#if DEBUG
		builder.Logging.AddDebug();
#endif

		//TODO: use interface
		builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddTransient<MainPage>();

        builder.Services.AddScoped<ListaContentViewModel>();
        builder.Services.AddScoped<ListaContentView>();

        builder.Services.AddScoped<KoloryContentViewModel>();
        builder.Services.AddScoped<KoloryContentView>();

        builder.Services.AddScoped<IElementFactory, ElementFactory>();
        builder.Services.AddScoped<IElementService, ElementService>();

        return builder.Build();
	}
}
