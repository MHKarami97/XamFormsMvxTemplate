// ---------------------------------------------------------------
// <author>Paul Datsyuk</author>
// <url>https://www.linkedin.com/in/pauldatsyuk/</url>
// ---------------------------------------------------------------

using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using System;

namespace $safeprojectname$.Pages
{
    [MvxMasterDetailPagePresentation(MasterDetailPosition.Root, WrapInNavigationPage = false)]
    public partial class RootPage : MvxMasterDetailPage
    {
        public RootPage()
        {
            InitializeComponent();

            this.IsPresentedChanged += RootPage_IsPresentedChanged;
        }

        private void RootPage_IsPresentedChanged(object sender, EventArgs e)
        {
            //To Do Something
        }
    }
}