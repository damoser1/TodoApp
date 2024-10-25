using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using TodoApp.Core.Interfaces;
using TodoApp.Core.ViewModels;
using TodoApp.TodoData;

namespace TodoApp.Gui
{
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
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
            // MainViewModel
            builder.Services.AddSingleton<MainViewModel>();
            // MainPage
            builder.Services.AddSingleton<MainPage>();
            // Für IRepository ein neues Objekt erstellen
            builder.Services.AddSingleton<IRepository>(new StaticData());
#endif

            return builder.Build();
        }
    }
}
