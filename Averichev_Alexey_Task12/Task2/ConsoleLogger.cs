using System;

namespace Task2
{
    public class ConsoleLogger : ILoggable
    {
        public void LogMessage(string name)
        {
            Console.WriteLine(name);
        }
    }
}
