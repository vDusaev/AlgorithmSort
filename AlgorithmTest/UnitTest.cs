using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;

namespace AlgorithmTest
{
    [TestClass]
    public class UnitTest
    {
        Random rnd = new Random();
        List<int> Items = new List<int>();
        List<int> Sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            Items.Clear();
            Sorted.Clear();

            for (int i = 0; i < 10000; i++)
            {
                Items.Add(rnd.Next(0, 10000));
            }

            Sorted.AddRange(Items.OrderBy(x => x).ToArray());
        }

        [TestMethod()]
        public void BaseSortTest()
        {
            // arrange
            var baseSort = new BaseSort<int>(Items);

            // act
            baseSort.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], baseSort.Items[i]);
            }
        }

        [TestMethod()]
        public void BubbleSortTest()
        {
            // arrange
            var bubbleSort = new BubbleSort<int>(Items);

            // act
            bubbleSort.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bubbleSort.Items[i]);
            }
        }

        [TestMethod()]
        public void CocktailSortTest()
        {
            // arrange
            var cocktailSort = new CocktailSort<int>(Items);

            // act
            cocktailSort.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], cocktailSort.Items[i]);
            }
        }

        [TestMethod()]
        public void InsertSortTest()
        {
            // arrange
            var insertSort = new InsertSort<int>(Items);

            // act
            insertSort.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insertSort.Items[i]);
            }
        }

        [TestMethod()]
        public void ShellSortTest()
        {
            // arrange
            var shellSort = new ShellSort<int>(Items);

            // act
            shellSort.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], shellSort.Items[i]);
            }
        }

        [TestMethod()]
        public void SelectionSortTest()
        {
            // arrange
            var selectionSort = new SelectionSort<int>(Items);

            // act
            selectionSort.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], selectionSort.Items[i]);
            }
        }

        [TestMethod()]
        public void GnomeSortTest()
        {
            // arrange
            var gnomeSort = new GnomeSort<int>(Items);

            // act
            gnomeSort.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], gnomeSort.Items[i]);
            }
        }

        [TestMethod()]
        public void RadixSortLSDTest()
        {
            // arrange
            var radixSort = new RadixSort<int>(Items);

            // act
            radixSort.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], radixSort.Items[i]);
            }
        }

        [TestMethod()]
        public void RadixSortMSDTest()
        {
            // arrange
            var radixSort = new RadixSort<int>(Items);

            // act
            radixSort.Sort(false);

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], radixSort.Items[i]);
            }
        }

        [TestMethod()]
        public void MergeSortTest()
        {
            // arrange
            var mergeSort = new MergeSort<int>(Items);

            // act
            mergeSort.Sort();

            // assert
            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], mergeSort.Items[i]);
            }
        }
    }
}
