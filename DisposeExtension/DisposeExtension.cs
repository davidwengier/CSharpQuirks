using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpQuirks.DisposeExtension
{
    public static class DisposeExtension
    {
        public static void DoSomeWork()
        {
            //int c = 5;
            //using (c)
            //{
            //    Console.WriteLine("Starting...");
            //}

            //using (new MyDisposable()) { }

            //using (new MyCustomDisposable()) { }

            //using (new MyExtendedDisposable()) { }

            //using var x = new MyDisposable();

            //using var z = new MyCustomDisposable();

            //using var p = new MyExtendedDisposable();
        }

        public static void Dispose(this MyExtendedDisposable thing)
        {
        }
    }

    public class MyExtendedDisposable
    {
    }

    public class MyDisposable : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

    public class MyCustomDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
