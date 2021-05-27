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

        /*
        Your task is to implement `IEnumerable.MySelect` extension method. You will need to return an instance of `MySelectEnumerable` that is a wrapper enumerable; it takes an `IEnumerable<TSource>` and a `Func<TSource, TResult>` and when the current element is requested it returns the current element of the `IEnumerable<TSource>` with the `Func<TSource, TResult>` applied, therefore a `TResult` instance.
        */
        [TestMethod]
        public void MySelect_AppliesFunction()
        {
            var range = Enumerable.Range(1, 9);

            var result = range.MySelect(i => (char)(((int)'a') + i));

            var expected = "bcdefghij";
            Assert.IsTrue(expected.SequenceEqual(result));
        }

        /*
        Your task is to implement `IEnumerable.MyWhere` extension method. You will need to return an instance of `MyWhereEnumerable` that is a wrapper enumerable; it takes an `IEnumerable<TSource>` and a `Func<TSource, bool>` and when the next element is requested it returns the next element that returns true for the `Func<TSource, bool>` function.
        */
        [TestMethod]
        public void MyWhere_FiltersResults()
        {
            var range = Enumerable.Range(1, 100).Select(i => (char)i);

            var result = range.MyWhere(char.IsDigit);

            var expected = "0123456789";
            Assert.IsTrue(expected.SequenceEqual(result));
        }
    }
}
