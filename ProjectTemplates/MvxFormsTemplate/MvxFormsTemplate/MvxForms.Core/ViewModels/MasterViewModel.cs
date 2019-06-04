// ---------------------------------------------------------------
// <author>Paul Datsyuk</author>
// <url>https://www.linkedin.com/in/pauldatsyuk/</url>
// ---------------------------------------------------------------

using MvvmCross.Navigation;
using MvvmCross.ViewModels;

namespace $safeprojectname$.ViewModels
{
    public class MasterViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService navigationService;

        public MasterViewModel(IMvxNavigationService navigationService)
        {
            this.navigationService = navigationService;
        }
    }
}