using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpQuirks.InterfaceWithoutImplenting
{
    public interface ICountable
    {
        int Count { get; }
    }

    public class MyDictionary<T, V> : Dictionary<T, V>, ICountable
    {
    }

    public class Example2
    {
        public Example2()
        {
            var dict = new MyDictionary<string, string>()
            {
                ["adsf"] = "qwre",
                ["poi"] = "hih"
            };

            CountEm(dict);
        }

        private void CountEm(ICountable countable)
        {
            Console.WriteLine(countable.Count);
        }
    }
}
