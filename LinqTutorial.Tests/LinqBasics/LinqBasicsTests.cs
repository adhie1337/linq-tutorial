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
            var range = (IEnumerable<int>)null;

            var result = range.ToArray();

            CollectionAssert.AreEqual(new[] { 0, 0, 0 }, result);
        }
    }
}
