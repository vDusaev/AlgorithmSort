using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class InsertSort<T> : BaseSort<T> where T : IComparable
    {
        public InsertSort() : base() { }
        public InsertSort(T data) : base(data) { }
        public InsertSort(IEnumerable<T> items) : base(items) { }

        public override void Sort()
        {
            for (int i = 1; i < Items.Count; i++)
            {
                var j = i;
                while (j > 0 && Items[j].CompareTo(Items[j - 1]) == -1)
                {
                    Swop(j, j - 1);
                    j--;
                }
            }
        }
    }
}
