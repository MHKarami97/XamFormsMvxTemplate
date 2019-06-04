using System.Collections.Generic;
using System.Reflection;
using MvvmCross.Forms.Platforms.Uap.Views;
using Windows.ApplicationModel.Activation;
using FFImageLoading.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;

namespace SmartHome.UWP
{
    sealed partial class App
    {
        public App()
        {
            InitializeComponent();
        }
    }

    public abstract class UwpApp : MvxWindowsApplication<Setup, Core.MvxApp, Core.FormsApp, MainPage>
    {
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {

#if DEBUG
            if (System.Diagnostics.Debugger.IsAttached)
            {
                this.DebugSettings.EnableFrameRateCounter = true;
            }
#endif

            var config = new FFImageLoading.Config.Configuration
            {
                VerboseLogging = false,
                VerbosePerformanceLogging = false,
                VerboseMemoryCacheLogging = false,
                VerboseLoadingCancelledLogging = false,
            };
            FFImageLoading.ImageService.Instance.Initialize(config);

            var assembliesToInclude = new List<Assembly>
            {
                typeof(CachedImage).GetTypeInfo().Assembly,
                typeof(FFImageLoading.Forms.Platform.CachedImageRenderer).GetTypeInfo().Assembly
            };

            Xamarin.Forms.Forms.Init(e, assembliesToInclude);

            FFImageLoading.Forms.Platform.CachedImageRenderer.Init();

            //AppCenter.Start("", typeof(Analytics));

            base.OnLaunched(e);
        }
    }
}