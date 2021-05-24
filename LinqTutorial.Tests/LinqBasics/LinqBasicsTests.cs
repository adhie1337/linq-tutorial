using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqTutorial.Tests
{
    [TestClass]
    public class LinqBasicsTests
    {

        [TestMethod]
        public void EnumerableRepeat_ReturnsNElements()
        {
            var range = Enumerable.Repeat(0, 3);

            var result = range.ToArray();

            CollectionAssert.AreEqual(new[] { 0, 0, 0 }, result);
        }
    }
}
