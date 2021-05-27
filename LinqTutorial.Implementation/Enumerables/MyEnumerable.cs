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
        private readonly IEnumerable<TSource> _source;
        private readonly Predicate<TSource> _predicate;

        public MyWhereEnumerable(IEnumerable<TSource> source, Predicate<TSource> predicate) => (this._source, this._predicate) = (source, predicate);

        public IEnumerator<TSource> GetEnumerator() => new MyWhereEnumerator<TSource>(this._source.GetEnumerator(), this._predicate);

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        private struct MyWhereEnumerator<TS> : IEnumerator<TS>
        {
            private readonly IEnumerator<TS> _source;
            private readonly Predicate<TS> _predicate;

            public MyWhereEnumerator(IEnumerator<TS> source, Predicate<TS> predicate) => (this._source, this._predicate) = (source, predicate);

            public TS Current => this._source.Current;

            object IEnumerator.Current => this.Current;

            public bool MoveNext()
            {
                do
                {
                    if (!this._source.MoveNext()) return false;
                } while (!this._predicate(this._source.Current));

                return true;
            }

            public void Reset() => this._source.Reset();

            public void Dispose() => this._source.Dispose();
        }
    }

    public static class EnumerableExtensions
    {
        public static IEnumerable<TResult> MySelect<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> resultSelector) => throw new NotImplementedException();

        public static IEnumerable<TSource> MyWhere<TSource>(this IEnumerable<TSource> source, Predicate<TSource> predicate) => new MyWhereEnumerable<TSource>(source, predicate);
    }
}
