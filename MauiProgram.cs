﻿using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using ProtoDevMaui.Services;
using ProtoDevMaui.ViewModels;
using ProtoDevMaui.Views;

namespace ProtoDevMaui
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
                    fonts.AddFont("Ubuntu-Regular.ttf", "UbuntuRegular");
                    fonts.AddFont("Ubuntu-Bold.ttf", "UbuntuBold");
                })
                .UseMauiCommunityToolkit();
            builder.Services.AddSingleton<CategoryService>();
            builder.Services.AddSingleton<HomePageViewModel>();
            builder.Services.AddSingleton<HomePage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
