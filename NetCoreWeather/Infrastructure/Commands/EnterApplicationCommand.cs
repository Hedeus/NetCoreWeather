using NetCoreWeather.Infrastructure.Commands.Base;
using System;
using System.Windows;

namespace NetCoreWeather.Infrastructure.Commands
{
    internal class EnterApplicationCommand : Command
    {
        private MainWindow _Window;
        public override bool CanExecute(object parameter) => _Window == null;
       
        public override void Execute(object parameter)
        {
            var window = new MainWindow();
            _Window = window;
            window.Closed += OnWindowClosed;
            window.Show();
            Application.Current.MainWindow.Close();
        }

        private void OnWindowClosed(object sender, EventArgs e)
        {
            ((Window)sender).Closed -= OnWindowClosed;
            _Window = null;
        }
    }
}
