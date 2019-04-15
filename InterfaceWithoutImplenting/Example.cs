using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpQuirks.InterfaceWithoutImplenting
{
    public static class Example
    {
        public static void DoSomething()
        {
            IFoo foo = new Bar();
            foo.BazMethod();
        }
    }

    public interface IFoo
    {
        void BazMethod();
    }

    public class Baz
    {
        public void BazMethod()
        {
        }
    }

    public class Bar : Baz, IFoo
    {
    }
}
