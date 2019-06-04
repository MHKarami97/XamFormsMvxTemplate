

using MvvmCross;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.Logging;
using Serilog;

namespace SmartHome.Droid
{
    public class Setup : MvxFormsAndroidSetup<Core.MvxApp, Core.FormsApp>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            Mvx.IoCProvider.RegisterSingleton<Core.Services.ILocalizeService>(() => new Services.LocalizeService());
        }

        public override MvxLogProviderType GetDefaultLogProviderType() => MvxLogProviderType.Serilog;

        protected override IMvxLogProvider CreateLogProvider()
        {
            Log.Logger = new LoggerConfiguration()
                        .MinimumLevel.Debug()
                        .WriteTo.AndroidLog()
                        .CreateLogger();

            return base.CreateLogProvider();
        }
    }
}