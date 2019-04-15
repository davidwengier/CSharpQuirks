using System;

namespace CSharpQuirks.NullConditionalLogging
{
    public static class NullConditionalLogging
    {
        public static void DoSomeWork()
        {
            Log.Debug?.Log("Status: " + ComputeExpensiveStatus());
        }

        private static string ComputeExpensiveStatus()
        {
            Console.WriteLine("Please wait 5 seconds while I calculate things.");
            System.Threading.Thread.Sleep(5000);
            return "All good!";
        }
    }
}
