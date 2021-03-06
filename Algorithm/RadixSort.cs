﻿using System;
using System.Collections.Generic;

namespace Algorithm
{
    public class RadixSort<T> : BaseSort<T> where T : IComparable
    {
        public RadixSort() : base() { }
        public RadixSort(T data) : base(data) { }
        public RadixSort(IEnumerable<T> items) : base(items) { }

        public override void Sort()
        {
            base.Sort();
        }
        public void Sort(bool LSD = true)
        {
            if (LSD)
                SortLSD();
            else
                SortMSD();
        }
        private void SortLSD()
        {
            var dictionary = new List<Queue<T>>();
            for (int i = 0; i < 10; i++)
            {
                dictionary.Add(new Queue<T>());
            }

            var countOfDigits = getCountsOfDigits();

            for (int i = 0; i < countOfDigits; i++)
            {
                foreach (var item in Items)
                {
                    var indexDictionary = item.GetHashCode() % (int)Math.Pow(10, i + 1) / (int)Math.Pow(10, i);
                    dictionary[indexDictionary].Enqueue(item);
                }

                var indexItems = 0;
                foreach (var itemDictionary in dictionary)
                {
                    while (itemDictionary.Count != 0)
                    {
                        Items[indexItems] = itemDictionary.Dequeue();
                        indexItems++;
                    }
                }
            }
        }
        private void SortMSD()
        {
            var countOfDigits = getCountsOfDigits();
            var result = SortMSD(Items, countOfDigits - 1);

            for (int i = 0; i < result.Count; i++)
            {
                Items[i] = result[i];
            }
        }
        private List<T> SortMSD(List<T> collections, int step)
        {
            var result = new List<T>();

            var dictionary = new List<List<T>>();
            for (int i = 0; i < 10; i++)
            {
                dictionary.Add(new List<T>());
            }

            foreach (var itemСollections in collections)
            {
                var indexDictionary = itemСollections.GetHashCode() % (int)Math.Pow(10, step + 1) / (int)Math.Pow(10, step);
                dictionary[indexDictionary].Add(itemСollections);
            }

            foreach (var itemDictionary in dictionary)
            {
                if (itemDictionary.Count > 1 && step > 0)
                {
                    result.AddRange(SortMSD(itemDictionary, step - 1));
                    continue;
                }

                result.AddRange(itemDictionary);
            }

            return result;
        }

        private int getCountsOfDigits()
        {
            var countOfDigits = 0;
            foreach (var item in Items)
            {
                if (item.GetHashCode() < 0)
                {
                    throw new ArgumentException("Radix sort supports only whole numbers", nameof(Items));
                }

                var newCountOfDigits = (item.GetHashCode() == 0) ? 1 : (int)Math.Ceiling(Math.Log10(Math.Abs(item.GetHashCode()) + 0.5));
                if (countOfDigits < newCountOfDigits)
                {
                    countOfDigits = newCountOfDigits;
                }
            }

            return countOfDigits;
        }
    }
}
