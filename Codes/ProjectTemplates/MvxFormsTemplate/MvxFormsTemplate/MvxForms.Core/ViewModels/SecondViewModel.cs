// ---------------------------------------------------------------
// <author>Paul Datsyuk</author>
// <url>https://www.linkedin.com/in/pauldatsyuk/</url>
// ---------------------------------------------------------------

using Acr.UserDialogs;
using MvvmCross.Commands;
using MvvmCross.Navigation;
using MvvmCross.ViewModels;
using $safeprojectname$.Helpers;
using $safeprojectname$.Services;
using System.Collections.Generic;

namespace $safeprojectname$.ViewModels
{
    public class SecondViewModel : MvxViewModel<Dictionary<string, string>>
    {
        private readonly IMvxNavigationService navigationService;
        private readonly Services.IAppSettings settings;
        private readonly IUserDialogs userDialogs;
        private readonly ILocalizeService localizeService;

        private Dictionary<string, string> _parameter;

        public SecondViewModel(IMvxNavigationService navigationService, Services.IAppSettings settings, IUserDialogs userDialogs, ILocalizeService localizeService)
        {
            this.navigationService = navigationService;
            this.settings = settings;
            this.userDialogs = userDialogs;
            this.localizeService = localizeService;

            MainPageButtonText = "test";
        }

        public string MainPageButtonText { get; set; }

        public IMvxAsyncCommand BackCommand => new MvxAsyncCommand(async () =>
        {
            var localizedText = localizeService.Translate("SecondPage_ByeBye_Localization");

            await userDialogs.AlertAsync(localizedText);
            await navigationService.Close(this);
        });

        public override void Prepare(Dictionary<string, string> parameter)
        {
            _parameter = parameter;

            if (_parameter != null && _parameter.ContainsKey("ButtonText"))
                MainPageButtonText = "ButtonText";
        }

        public int SuperNumber
        {
            get { return settings.SuperNumber; }
            set { settings.SuperNumber = value; }
        }
    }
}