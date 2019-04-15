using System;

namespace CSharpQuirks.NullConditionalLogging
{
    internal class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Log: " + message);
        }
    }
}