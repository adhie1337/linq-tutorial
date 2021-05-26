using System.Linq;

using LinqTutorial.Implementation.Enumerables;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqTutorial.Tests.Enumerables
{
    [TestClass]
    public class MyEnumerablesTests
    {
        /*
        Your task is to implement `MyEnumerable` that is an implementor of `IEnumerable<int>`. It has a static method that is almost the same as `Enumerable.Range`, but `Enumerable.Range` takes two parameters: the start int, and the number of items to generate, but `MyEnumerable.Range` takes a start int and an end in exclusive.
        */
        [TestMethod]
        public void MyEnumerable_GeneratesInts()
        {
            var range = MyEnumerable.Range(1, 10);

            var expected = Enumerable.Range(1, 9);
            Assert.IsTrue(expected.SequenceEqual(range));
        }
    }
}
