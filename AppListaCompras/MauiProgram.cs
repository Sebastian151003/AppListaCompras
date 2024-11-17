using Microsoft.Extensions.Logging;

namespace AppListaCompras
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

            string dbPath = FileAccessHelper.GetLocalFilePath("BD_AppLista.db");
            //string dbPath = @"C:\Users\Jose_Maria\Downloads\BD\BD_AppLista.db";

            builder.Services.AddSingleton<UsuarioRepository>
                   (s => ActivatorUtilities.CreateInstance<UsuarioRepository>(s, dbPath));

#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}
