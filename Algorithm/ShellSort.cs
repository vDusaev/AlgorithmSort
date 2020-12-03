using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class ShellSort<T> : BaseSort<T> where T : IComparable
    {
        public ShellSort() : base() { }
        public ShellSort(T data) : base(data) { }
        public ShellSort(IEnumerable<T> items) : base(items) { }

        public override void Sort()
        {
            int step = Items.Count / 2;
            while (step > 0)
            {
                for (int i = step; i < Items.Count; i++)
                {
                    int j = i;
                    while (j >= step && Items[j].CompareTo(Items[j - step]) == -1)
                    {
                        Swop(j, j - 1);
                        j -= step;
                    }
                }

                step /= 2;
            }
        }
    }
}
