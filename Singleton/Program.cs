using System;

namespace DesignPatterns.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            // Check if both references point to the same object
            if (ReferenceEquals(s1, s2))
            {
                Console.WriteLine("Both objects are the same instance.");
            }
            else
            {
                Console.WriteLine("Different instances created!");
            }
        }
    }
}