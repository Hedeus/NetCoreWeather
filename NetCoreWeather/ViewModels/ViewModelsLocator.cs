using Microsoft.Extensions.DependencyInjection;

namespace NetCoreWeather.ViewModels
{
    internal class ViewModelLocator
    {
        public MainWindowViewModel MainWindowModel => App.Host.Services.GetRequiredService<MainWindowViewModel>();
        public WelcomeWindowModel WelcomeModel => App.Host.Services.GetRequiredService<WelcomeWindowModel>();
    }
}
