using System.Collections.Generic;
using System.Linq;

using LinqTutorial.Implementation.Stables;

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

        /*
        Notice we have a new project in the solution: `LinqTutorial.Implementation`. It has one namespace currently with the new record type `LinqTutorial.Implementation.Stables.Horse`. For these line of excercises, you can assume this is a third-party library, therefore **you can not change the code of `LinqTutorial.Implementation`**. Your task is to make the test green (as always). Use the `Select` method to do so.
        */
        [TestMethod]
        public void Select_CreatesHorses()
        {
            var range = Enumerable.Range(1, 3);

            var result = (IEnumerable<Horse>)null;

            Assert.IsTrue(new[] { new Horse(1), new Horse(2), new Horse(3) }.SequenceEqual(result));
        }

        /*
        The task is exactly the same as in 003, but you will have to use query syntax for this one. Google `Linq query syntax` to get some tips how to do that.
        */
        [TestMethod]
        public void Select_WithQuerySyntax_CreatesHorses()
        {
            var range = Enumerable.Range(1, 3);

            var result = (IEnumerable<Horse>)null;

            Assert.IsTrue(new[] { new Horse(1), new Horse(2), new Horse(3) }.SequenceEqual(result));
        }
    }
}
