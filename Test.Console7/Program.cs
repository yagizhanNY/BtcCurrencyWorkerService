using System;
using System.Configuration;

namespace Test.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ConfigurationManager.AppSettings.Get("test"));
        }
    }
}
