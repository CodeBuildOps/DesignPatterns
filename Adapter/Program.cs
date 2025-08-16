using System;

namespace DesignPatterns.Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMyLogger myLogger = new Adapter(new ThirdPartyLogger());

            // Behind the scenes, Adapter redirects to ThirdPartyLogger.WriteLog()
            myLogger.LogInfo("This is success msg");
            myLogger.LogError("This is error msg");
        }
    }
}