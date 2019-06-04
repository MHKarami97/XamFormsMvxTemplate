using MvvmCross.Logging;
using System;
using System.Diagnostics;

namespace $safeprojectname$
{
    public class DebugTrace : IMvxLog
    {
        public bool IsLogLevelEnabled(MvxLogLevel logLevel) => true;

        public bool Log(MvxLogLevel logLevel, Func<string> messageFunc, Exception exception = null, params object[] formatParameters)
        {
            Debug.WriteLine(logLevel + ":" + messageFunc());

            return true;
        }
    }
}