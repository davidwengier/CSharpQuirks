using System;

namespace CSharpQuirks.FormattableStrings
{
    public static class FormattableStrings
    {
        public static void DoSomething()
        {
            string myVal = "hello";
            int myInt = 7;

            var x = $"I want to say {myVal} to number {myInt}.";

            FormattableString y = $"I want to say {myVal} to number {myInt}.";

            foreach (var arg in y.GetArguments())
            {
                Console.WriteLine(arg);
            }

            FancyLogger.Log($"I want to say {myVal} to number {myInt}.");
        }
    }
}
