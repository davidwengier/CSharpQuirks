using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpQuirks.FormattableStrings
{
    public static class FancyLogger
    {
        public static void Log(FormattableString logString)
        {
            NullConditionalLogging.Log.Debug?.Log("The message was '" + logString.Format + "' and the parameters were:");
            foreach (var arg in logString.GetArguments())
            {
                NullConditionalLogging.Log.Debug?.Log("* " + arg);
            }
        }
    }
}
