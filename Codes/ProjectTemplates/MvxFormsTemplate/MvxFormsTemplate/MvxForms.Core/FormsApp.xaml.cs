using MvvmCross.Forms.Core;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace $safeprojectname$
{
    public partial class FormsApp : MvxFormsApplication
    {
        public FormsApp()
        {
            InitializeComponent();
	    XF.Material.Forms.Material.Init(this);
        }
    }
}