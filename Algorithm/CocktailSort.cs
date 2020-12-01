using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class CocktailSort<T> : BaseSort<T> where T : IComparable
    {
        public CocktailSort() : base() { }
        public CocktailSort(T data) : base(data) { }
        public CocktailSort(IEnumerable<T> items) : base(items) { }

        public override void Sort()
        {
            var left = 0;
            var right = Items.Count - 1;
            var change = false;

            while (left < right)
            {
                for (int i = left; i < right; i++)
                {
                    if (Items[i].CompareTo(Items[i + 1]) == 1)
                    {
                        Swop(i, i + 1);
                        change = true;
                    }
                }
                right--;

                if (!change)
                {
                    break;
                }

                for (int i = right; i > left; i--)
                {
                    if (Items[i].CompareTo(Items[i - 1]) == -1)
                    {
                        Swop(i, i - 1);
                        change = true;
                    }
                }
                left++;

                if (!change)
                {
                    break;
                }
            }
        }
    }
}
