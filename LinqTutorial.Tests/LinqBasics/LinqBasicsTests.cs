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

        /*
        You decide that there is no need to store all the horses in the dictionary, you will only need whether they are lucky or not. You decide that luck shouldn't be only a boolean flag, you decide to indicate luck with the new and more sophisticated `Luck` enum.

        Take a look at the test file `LinqTutorial.Tests/LinqBasics/LinqBasicsTests.cs`. You will notice that it already contains the new test using the new `Luck` enum, but it doesn't work. If you accept the suggestion in the comment, it won't even compile because there is no `GetLuck` function provided in the `Horse` type.

        The `Horse` class is still in a third-party library, **you can not change its code**. However, you can make an extension method that can be used like it would be a method of the `Horse` type.

        Note the new source file `LinqTutorial.Tests/LinqBasics/Horses.cs`.
        */
        [TestMethod]
        public void GetLuckExtensionMethod_Works()
        {
            var horses = from id in Enumerable.Range(1, 3) select new Horse(id);

            // TODO: use horse.GetLuck() here instead of hardwired UnLucky value
            var result = horses.ToDictionary(horse => horse.Id, horse => Luck.UnLucky);

            var expected = new Dictionary<int, Luck>()
            {
                { 1, Luck.Lucky },
                { 2, Luck.UnLucky },
                { 3, Luck.Lucky },
            };
            CollectionAssert.AreEquivalent(expected, result);
        }
    }
}
