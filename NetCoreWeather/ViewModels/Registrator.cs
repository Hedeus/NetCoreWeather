using Microsoft.Extensions.DependencyInjection;

namespace NetCoreWeather.ViewModels
{
    internal static class Registrator
    {
        public static IServiceCollection RegisterViewModels(this IServiceCollection services)
        {
            services.AddSingleton<MainWindowViewModel>();
            services.AddSingleton<WelcomeWindowModel>();

            return services;
        }
    }
}
