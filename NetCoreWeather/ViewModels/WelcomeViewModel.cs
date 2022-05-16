using NetCoreWeather.ViewModels.Base;
using System.Security;

namespace NetCoreWeather.ViewModels
{
    internal class WelcomeWindowModel : ViewModel
    {
        #region Title : string - Заголоваок окна
        private string _Title = "Приветственное окно";

        public string Title { get => _Title; set => Set(ref _Title, value); }
        #endregion

        #region WelcomeText : string - Текст приветствия
        private string _WelcomeText = "Програма відображає інформацію про погоду за 2021 рік";

        public string WelcomeText { get => _WelcomeText; set => Set(ref _WelcomeText, value); }
        #endregion        
    }
}
