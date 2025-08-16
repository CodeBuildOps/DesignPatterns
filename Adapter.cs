using System;

namespace DesignPatterns.AdapterPattern
{
    // 1. Target interface - What your app expects
    public interface ILogger
    {
        void LogInfo(string msg);
    }

    // Your own logger implementation
    public class Log : ILogger
    {
        public void LogInfo(string msg)
        {
            Console.WriteLine(msg);
        }
    }

    // 2. Adaptee (3rd party NuGet package class - cannot be modified!)
    public class ThirdPartyLogger
    {
        public void WriteLog(string severity, string msg)
        {
            Console.WriteLine("[{0}] {1}", severity, msg);
        }
    }

    // 3. Adapter - makes ThirdPartyLogger fit ILogger interface
    public class LoggerAdapter : ILogger
    {
        private readonly ThirdPartyLogger _thirdPartyLogger;

        public LoggerAdapter(ThirdPartyLogger thirdPartyLogger)
        {
            _thirdPartyLogger = thirdPartyLogger;
        }

        public void LogInfo(string msg)
        {
            // Converts ILogger's expected method into the ThirdPartyLogger call
            string severity = "Info";
            _thirdPartyLogger.WriteLog(severity, msg);
        }
    }
}