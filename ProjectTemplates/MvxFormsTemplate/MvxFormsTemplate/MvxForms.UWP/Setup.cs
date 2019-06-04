

using MvvmCross;
using MvvmCross.Forms.Platforms.Uap.Core;
using MvvmCross.Logging;
using Serilog;
using System.IO;
using Windows.Storage;

namespace SmartHome.UWP
{
    public class Setup : MvxFormsWindowsSetup<Core.MvxApp, Core.FormsApp>
    {
        protected override void InitializeFirstChance()
        {
            base.InitializeFirstChance();

            Mvx.IoCProvider.RegisterSingleton<Core.Services.ILocalizeService>(() => new Services.LocalizeService());
        }

        public override MvxLogProviderType GetDefaultLogProviderType() => MvxLogProviderType.Serilog;

        protected override IMvxLogProvider CreateLogProvider()
        {
            var logPath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "Logs", "log-{Date}.txt");

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.Trace()
                .WriteTo.RollingFile(logPath)
                .CreateLogger();

            return base.CreateLogProvider();
        }
    }
}