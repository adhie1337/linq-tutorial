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
            var range = Enumerable.Repeat(0, 3);

            Assert.IsTrue(new[] { 0, 0, 0 }.SequenceEqual(range));
        }
    }
}
