// ---------------------------------------------------------------
// <author>Paul Datsyuk</author>
// <url>https://www.linkedin.com/in/pauldatsyuk/</url>
// ---------------------------------------------------------------

using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace $safeprojectname$.ViewModels
{
    public class RootViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService navigationService;

        public RootViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
        }

        public override void ViewAppearing()
        {
            base.ViewAppearing();

            MvxNotifyTask.Create(async () =>
            {
                await navigationService.Navigate<MasterViewModel>();
                await navigationService.Navigate<MainViewModel>();
            });
        }
    }
}