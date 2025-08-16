using System;

namespace DesignPatterns.Adapter
{
    // 1. Target interface - What your app expects
    interface IMyLogger
    {
        void LogInfo(string msg);
        void LogError(string msg);
    }
    internal class MyLogger : IMyLogger
    {
        public void LogInfo(string msg)
        {
            Console.WriteLine("Info - Log");
        }
        public void LogError(string msg)
        {
            Console.WriteLine("Error -  Log");
        }
    }
}