using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class BubbleSort<T> : BaseSort<T> where T : IComparable
    {
        public BubbleSort() : base() { }
        public BubbleSort(T data) : base(data) { }
        public BubbleSort(IEnumerable<T> items) : base(items) { }

        public override void Sort()
        {
            var count = Items.Count;
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (Items[j].CompareTo(Items[j + 1]) == 1)
                    {
                        Swop(j, j + 1);
                    }
                }
            }
        }
    }
}
