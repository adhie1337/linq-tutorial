using System;
using System.Collections;
using System.Collections.Generic;

namespace LinqTutorial.Implementation.Enumerables
{
    public class MyEnumerable : IEnumerable<int>
    {
        private readonly int _start;
        private readonly int _end;

        public MyEnumerable(int start, int end) => (this._start, this._end) = (start, end);

        public IEnumerator<int> GetEnumerator() => new MyEnumerator(this._start, this._end);

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

        public static MyEnumerable Range(int start, int end) => new MyEnumerable(start, end);

        private struct MyEnumerator : IEnumerator<int>
        {
            private readonly int _start;
            private readonly int _end;

            private int _current;

            public int Current => this._current;

            object IEnumerator.Current => this.Current;

            internal MyEnumerator(int start, int end) => (this._start, this._end, this._current) = (start, end, start - 1);

            public bool MoveNext() => ++this._current < this._end;

            public void Reset() => this._current = this._start - 1;

            public void Dispose() { }
        }
    }
}
