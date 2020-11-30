using System;
using System.Collections;
using System.Collections.Generic;

namespace Algorithm
{
    class BaseSort<T> : IEnumerable where T : IComparable
    {
        public List<T> Items = new List<T>();
        public int SwopCount { get; protected set; } = 0;

        public BaseSort() { }
        public BaseSort(T data)
        {
            Add(data);
        }
        public BaseSort(IEnumerable<T> items)
        {
            Items.AddRange(items);
        }

        public void Add(T data)
        {
            Items.Add(data);
        }

        protected void Swop(int positionA, int positionB)
        {
            if (positionA < Items.Count && positionB < Items.Count)
            {
                var tempData = Items[positionA];
                Items[positionA] = Items[positionB];
                Items[positionB] = tempData;

                SwopCount++;
            }
        }

        public virtual void Sort()
        {
            Items.Sort();
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in Items)
            {
                yield return item;
            }
        }
    }
}
