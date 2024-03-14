using Camera.MAUI;
using KTI_Testing__Mobile_.Resources.viewModels;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui.Markup;

namespace MauiApp2
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
            
    		builder.Logging.AddDebug();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MauiLoginPage>();
            builder.Services.AddSingleton<LoginPageViewModel>();
            builder.UseMauiCameraView();
            builder.UseMauiApp<App>().UseMauiCommunityToolkitMarkup();
            return builder.Build();
        }
    }
}