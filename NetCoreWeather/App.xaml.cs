using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NetCoreWeather.Services;
using NetCoreWeather.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;

namespace NetCoreWeather
{

    public partial class App : Application
    {
        public static bool IsDesignMode { get; private set; } = true;

        private static IHost __Host;
        public static IHost Host  // => IHost host = __Host ??= Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();
        {
            get
            {
                if (__Host is null)
                    __Host = Program.CreateHostBuilder(Environment.GetCommandLineArgs()).Build();
                return __Host;
            }
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            IsDesignMode = false;
            var host = Host;
            base.OnStartup(e);

            await host.StartAsync().ConfigureAwait(false);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            var host = Host;
            await host.StopAsync().ConfigureAwait(false);
            host.Dispose();
            __Host = null;
        }

        internal static void ConfigureServices(HostBuilderContext host, IServiceCollection services) => services
            .RegisterService()
            .RegisterViewModels();


        public static string CurrentDirectory => IsDesignMode
            ? Path.GetDirectoryName(GetSourceCodePath())
            : Environment.CurrentDirectory;

        private static string GetSourceCodePath([CallerFilePath] string Path = null) => Path;
    }
}
