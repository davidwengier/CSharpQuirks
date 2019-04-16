using System.Collections;

namespace CSharpQuirks.CollectionInitializers
{
    public class MyThings : IEnumerable
    {
        public void Add(int number, string value)
        {
        }

        public IEnumerator GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}