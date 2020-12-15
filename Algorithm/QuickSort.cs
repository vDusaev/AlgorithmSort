using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class QuickSort<T> : BaseSort<T> where T : IComparable
    {
        public QuickSort() : base() { }
        public QuickSort(T data) : base(data) { }
        public QuickSort(IEnumerable<T> items) : base(items) { }

        public override void Sort()
        {
            Sort(0, Items.Count - 1);
        }
        private void Sort(int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            var pivor = Sorting(left, right);
            Sort(left, pivor - 1);
            Sort(pivor + 1, right);
        }
        private int Sorting(int left, int right)
        {
            var pointer = left;
            for (int i = left; i <= right; i++)
            {
                if (Items[i].CompareTo(Items[right]) == -1)
                {
                    Swop(pointer, i);
                    pointer++;
                }
            }

            Swop(pointer, right);
            return pointer;
        }
    }
}
