using System.Linq;

using LinqTutorial.Implementation.Enumerables;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqTutorial.Tests.Enumerables
{
    [TestClass]
    public class MyEnumerablesTests
    {
        [TestMethod]
        public void MyEnumerable_GeneratesInts()
        {
            var range = MyEnumerable.Range(1, 10);

            var expected = Enumerable.Range(1, 9);
            Assert.IsTrue(expected.SequenceEqual(range));
        }
    }
}
