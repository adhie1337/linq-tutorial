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

        /*
        Your task is to filter the horses to keep only the lucky ones with the `Where` method. Notice the new property `IsLucky` of the `Horse` type. Use method syntax for this test.
        */
        [TestMethod]
        public void Where_WithMethodSyntax_FiltersHorses()
        {
            var range = Enumerable.Range(1, 3);

            var result = range.Select(id => new Horse(id));

            Assert.IsTrue(new[] { new Horse(1), new Horse(3) }.SequenceEqual(result));
        }

        /*
        Your task is to filter the horses to keep only the lucky ones with the `Where` method. Notice the new property `IsLucky` of the `Horse` type. Use query syntax for this test.
        */
        [TestMethod]
        public void Where_WithQuerySyntax_FiltersHorses()
        {
            var range = Enumerable.Range(1, 3);

            var result = from id in range select new Horse(id);

            Assert.IsTrue(new[] { new Horse(1), new Horse(3) }.SequenceEqual(result));
        }

        /*
        Your task is to create a `Dictionary<int, Horse>` where the keys are the ids of the horses. You will need to use the `IEnumerable.ToDictionary` method. Note that there is no query syntax-equivalent of the `ToDictionary` method.
        */
        [TestMethod]
        public void ToDictionary_CreatesDictionary()
        {
            var horses = from id in Enumerable.Range(1, 3) select new Horse(id);

            var result = (Dictionary<int, Horse>)null;

            var expected = new Dictionary<int, Horse>()
            {
                { 1, new Horse(1) },
                { 2, new Horse(2) },
                { 3, new Horse(3) },
            };
            CollectionAssert.AreEquivalent(expected, result);
        }
    }
}
