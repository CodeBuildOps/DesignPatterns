using System;
namespace DesignPatterns.Adapter
{
    // 2. Adaptee (3rd party NuGet package class - cannot be modified!)
    internal class ThirdPartyLogger
    {
        public void WriteLog(string severity, string msg)
        {
            Console.WriteLine("[{0}] - {1}", severity, msg);
        }
    }
}