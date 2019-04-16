using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpQuirks.CollectionInitializers
{
    public static class Example
    {
        public static void DoSomething()
        {
            var list = new List<string>
            {
                "Example 1",
                "Example 2"
            };

            var dict = new Dictionary<string, string>
            {
                { "Key1", "Value1" },
                { "Key2", "Value2" }
            };

            var dict2 = new Dictionary<string, string>
            {
                ["Key1"] = "Value1",
                ["Key2"] = "Value2"
            };
        }

        public static void CustomAdd()
        {
            var foo = new MyThings
            {
                { 1, "My Thing 1" },
                { 2, "My Thing 2" },
                { 1, "My Other Thing 3" }
            };
        }
    }
}
