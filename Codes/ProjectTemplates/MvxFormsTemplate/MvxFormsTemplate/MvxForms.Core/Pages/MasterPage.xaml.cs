// ---------------------------------------------------------------
// <author>Paul Datsyuk</author>
// <url>https://www.linkedin.com/in/pauldatsyuk/</url>
// ---------------------------------------------------------------

using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;

namespace $safeprojectname$.Pages
{
    [MvxMasterDetailPagePresentation(MasterDetailPosition.Master)]
    public partial class MasterPage : MvxContentPage
    {
        public MasterPage()
        {
            InitializeComponent();
        }
    }
}