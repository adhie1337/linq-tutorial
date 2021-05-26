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

        [TestMethod]
        public void MySelect_AppliesFunction()
        {
            var range = Enumerable.Range(1, 9);

            var result = range.MySelect(i => (char)(((int)'a') + i));

            var expected = "bcdefghij";
            Assert.IsTrue(expected.SequenceEqual(result));
        }
    }
}
