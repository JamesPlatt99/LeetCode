using LeetCode_Stuff;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class MedianOfTwoSortedArraysTests
    {
        private MedianOfTwoSortedArraysSolution _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new MedianOfTwoSortedArraysSolution();
        }

        [TestMethod]
        public void OrderedLists()
        {
            int[] array1 = new int[] { 1, 2 };
            int[] array2 = new int[] { 3, 4 };
            double answer = _solution.FindMedianSortedArrays(array1, array2);
            Assert.AreEqual(answer, 2.5);
        }

        [TestMethod]
        public void ListsNotInOrderToMerge()
        {
            int[] array1 = new int[] { 1, 3};
            int[] array2 = new int[] { 2, 4};
            double answer = _solution.FindMedianSortedArrays(array1, array2);
            Assert.AreEqual(answer, 2.5);
        }

        [TestMethod]
        public void OddNumberOfElements()
        {
            int[] array1 = new int[] { 1, 3 };
            int[] array2 = new int[] { 2 };
            double answer = _solution.FindMedianSortedArrays(array1, array2);
            Assert.AreEqual(answer, 2);
        }

        [TestMethod]
        public void Array1Empty()
        {
            int[] array1 = new int[] { };
            int[] array2 = new int[] { 4 };
            double answer = _solution.FindMedianSortedArrays(array1, array2);
            Assert.AreEqual(answer, 4);
        }

        [TestMethod]
        public void Array2Empty()
        {
            int[] array1 = new int[] { 4 };
            int[] array2 = new int[] { };
            double answer = _solution.FindMedianSortedArrays(array1, array2);
            Assert.AreEqual(answer, 4);
        }

        [TestMethod]
        public void Array1LongerThanArray2()
        {
            int[] array1 = new int[] { -2, -1, 7 };
            int[] array2 = new int[] { 1, 5 };
            double answer = _solution.FindMedianSortedArrays(array1, array2);
            Assert.AreEqual(answer, 1);
        }

        [TestMethod] 
        public void Array2LongerThanArray1()
        {
            int[] array1 = new int[] { 1, 6, 7};
            int[] array2 = new int[] { 4, 5 };
            double answer = _solution.FindMedianSortedArrays(array1, array2);
            Assert.AreEqual(answer, 5);
        }
    }
}