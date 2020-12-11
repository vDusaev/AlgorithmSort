using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
    public class MergeSort<T> : BaseSort<T> where T : IComparable
    {
        public MergeSort() : base() { }
        public MergeSort(T data) : base(data) { }
        public MergeSort(IEnumerable<T> items) : base(items) { }

        public override void Sort()
        {
            Items = Sort(Items);
        }
        private List<T> Sort(List<T> items)
        {
            if (items.Count == 1)
            {
                return items;
            }

            var middleItems = items.Count / 2;

            return Merge(Sort(items.Take(middleItems).ToList()), Sort(items.Skip(middleItems).ToList()));
        }
        private List<T> Merge(List<T> left, List<T> right)
        {
            var result = new List<T>();

            var length = left.Count + right.Count;
            var leftPosition = 0;
            var rightPosition = 0;

            for (int i = 0; i < length; i++)
            {
                if (leftPosition < left.Count && rightPosition < right.Count)
                {
                    if (left[leftPosition].CompareTo(right[rightPosition]) == -1)
                    {
                        result.Add(left[leftPosition]);
                        leftPosition++;
                    }
                    else
                    {
                        result.Add(right[rightPosition]);
                        rightPosition++;
                    }
                }
                else
                {
                    if (leftPosition < left.Count)
                    {
                        result.AddRange(left.Skip(leftPosition));
                    }
                    else
                    {
                        result.AddRange(right.Skip(rightPosition));
                    }
                    break;
                }
            }

            return result;
        }
    }
}
