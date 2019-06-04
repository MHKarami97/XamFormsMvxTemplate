

using MvvmCross;
using MvvmCross.Forms.Platforms.Ios.Core;
using MvvmCross.Logging;
using Serilog;

namespace SmartHome.iOS
{
    public class Setup : MvxFormsIosSetup<Core.MvxApp, Core.FormsApp>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            Mvx.RegisterSingleton<Core.Services.ILocalizeService>(() => new Services.LocalizeService());
        }

        public override MvxLogProviderType GetDefaultLogProviderType() => MvxLogProviderType.Serilog;

        protected override IMvxLogProvider CreateLogProvider()
        {
            Log.Logger = new LoggerConfiguration()
                        .MinimumLevel.Debug()
                        .WriteTo.NSLog()
                        .CreateLogger();

            return base.CreateLogProvider();
        }
    }
}