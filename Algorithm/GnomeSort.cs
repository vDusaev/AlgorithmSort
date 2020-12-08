using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class GnomeSort<T> : BaseSort<T> where T : IComparable
    {
        public GnomeSort() : base() { }
        public GnomeSort(T data) : base(data) { }
        public GnomeSort(IEnumerable<T> items) : base(items) { }

        public override void Sort()
        {
            var i = Items.Count > 0 ? 1 : 0;

            while (i < Items.Count)
            {
                if (i == 0 || Items[i].CompareTo(Items[i - 1]) != -1)
                {
                    i++;
                }
                else
                {
                    Swop(i, i - 1);
                    i--;
                }
            }
        }
    }
}
