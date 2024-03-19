using Microsoft.Extensions.Logging;

namespace Sample;

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

        builder.ConfigureMauiHandlers(handlers =>
        {
            handlers.AddHandler(typeof(GoogleAdsBannerView), typeof(GoogleAdsBannerHandler));
        });
        
#if DEBUG
        builder.Logging.AddDebug();
#endif


        var instance = GoogleMobileAds.GADMobileAds.SharedInstance;
        
        instance.StartWithCompletionHandler(status => {

        });

        return builder.Build();
    }
}