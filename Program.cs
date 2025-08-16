//using DesignPatterns;
using DesignPatterns.AdapterPattern;
//using DesignPatterns.Factory;
using System;
// using DesignPatterns.AbstractFactory;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Singleton
            //Singleton singleton = Singleton.GetInstance();

            // Consumer or Client

            // Factory Pattern
            //Waiter waiter = new Waiter();
            //Console.WriteLine(waiter.GetPizza("Veg"));

            // Abstract Factory Pattern
            //Waiter waiter = new Waiter("Veg");
            //Console.WriteLine(waiter.GetPrizza());
            //Console.WriteLine(waiter.GetBurger());

            // Adapter Design Patter

            // 4. Client - your application
            // Normally, client code depends only on ILogger
            ILogger logger = new LoggerAdapter(new ThirdPartyLogger());

            // Behind the scenes, Adapter redirects to ThirdPartyLogger.WriteLog()
            logger.LogInfo("Behind the scenes, calling WriteLog() from ThirdPartyLogger.");
        }
    }
}