using System.Collections.Generic;
using System.Linq;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqTutorial.Tests.LinqBasics
{
    [TestClass]
    public class LinqBasicsTests
    {
        /*
        In this excercise, you will need to make an enumerable of 3 zeroes. Google `Enumerable.Repeat` for hints.
        */
        [TestMethod]
        public void EnumerableRepeat_ReturnsNElements()
        {
            var range = (IEnumerable<int>)null;

            Assert.IsTrue(new[] { 0, 0, 0 }.SequenceEqual(range));
        }

        /*
        In this excercise, you will need to make an enumerable that retruns the numbers 1, 2 and 3. Google `Enumerable.Range` for hints.
        */
        [TestMethod]
        public void EnumerableRange_ReturnsNElements()
        {
            var range = (IEnumerable<int>)null;

            Assert.IsTrue(new[] { 1, 2, 3 }.SequenceEqual(range));
        }
    }
}
