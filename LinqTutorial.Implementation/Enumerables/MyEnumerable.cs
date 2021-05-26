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
        private IEnumerable<TSource> source;
        private Func<TSource, TResult> resultSelector;

        public MySelectEnumerable(IEnumerable<TSource> source, Func<TSource, TResult> resultSelector)
        {
            this.source = source;
            this.resultSelector = resultSelector;
        }

        public IEnumerator<TResult> GetEnumerator() => new MySelectEnumerator<TSource, TResult>(source.GetEnumerator(), resultSelector);

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        private readonly struct MySelectEnumerator<TS, TR> : IEnumerator<TR>
        {
            private readonly IEnumerator<TS> _source;
            private readonly Func<TS, TR> _resultSelector;

            public TR Current => this._resultSelector(this._source.Current);

            object IEnumerator.Current => this.Current;

            public MySelectEnumerator(IEnumerator<TS> source, Func<TS, TR> resultSelector) => (this._source, this._resultSelector) = (source, resultSelector);

            public bool MoveNext() => this._source.MoveNext();

            public void Reset() => this._source.Reset();

            public void Dispose() { }
        }
    }

    public static class EnumerableExtensions
    {
        public static IEnumerable<TResult> MySelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> resultSelector) => new MySelectEnumerable<TSource, TResult>(source, resultSelector);
    }
}
