using System;
using System.Collections;
using System.Collections.Generic;

namespace LinqTutorial.Implementation.Enumerables
{
    public class MyEnumerable : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator() => throw new NotImplementedException();

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        public static MyEnumerable Range(int start, int end) => throw new NotImplementedException();
    }

    public class MySelectEnumerable<TSource, TResult> : IEnumerable<TResult>
    {
        public IEnumerator<TResult> GetEnumerator() => throw new NotImplementedException();

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    public class MyWhereEnumerable<TSource> : IEnumerable<TSource>
    {
        public IEnumerator<TSource> GetEnumerator() => throw new NotImplementedException();

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }

    public static class EnumerableExtensions
    {
        public static IEnumerable<TResult> MySelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> resultSelector) => throw new NotImplementedException();

        public static IEnumerable<TSource> MyWhere<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> filter) => throw new NotImplementedException();
    }
}
