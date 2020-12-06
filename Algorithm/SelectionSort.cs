using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class SelectionSort<T> : BaseSort<T> where T : IComparable
    {
        public SelectionSort() : base() { }
        public SelectionSort(T data) : base(data) { }
        public SelectionSort(IEnumerable<T> items) : base(items) { }

        public override void Sort()
        {
            for (int i = 0; i < Items.Count - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < Items.Count; j++)
                {
                    if (Items[minIndex].CompareTo(Items[j]) == 1)
                    {
                        minIndex = j;
                    }
                }

                if (i != minIndex)
                {
                    Swop(i, minIndex);
                }
            }
        }
    }
}
