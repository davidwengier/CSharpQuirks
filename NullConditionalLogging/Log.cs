using System;

namespace CSharpQuirks.NullConditionalLogging
{
    internal static class Log
    {
        public static ILogger Debug => GetLogger(LogLevel.Debug);
        public static ILogger Error => GetLogger(LogLevel.Error);

        private static ILogger GetLogger(LogLevel level)
        {
            if (ShouldLog(level))
            {
                return new Logger();
            }
            return null;
        }

        private static bool ShouldLog(LogLevel level)
        {
            // TODO: Read a file, check level, whatever

            return false;
        }
    }

    internal enum LogLevel
    {
        Debug,
        Error
    }
}