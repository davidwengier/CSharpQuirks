using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpQuirks.DisposeExtension
{
    public static class ExtensionMethods
    {
        public static void Dispose(this int number)
        {
            Console.WriteLine("Finished " + number);
        }
    }
}
