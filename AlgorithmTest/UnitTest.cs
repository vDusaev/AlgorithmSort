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
    }
}
