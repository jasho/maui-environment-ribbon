using Microsoft.Extensions.Logging;

namespace MauiEnvironmentRibbon.SampleApp
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
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddTransient<Page2>();

            var app = builder.Build();

            Routing.RegisterRoute("page2", typeof(Page2));

            return app;
        }
    }
}
