using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_Stuff;

namespace Tests
{
    [TestClass]
    public class TwoSumTests
    {
        private TwoSumSolution _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new TwoSumSolution();
        }

        [TestMethod]
        public void DoesNotThrowError()
        {
            _solution.TwoSum(new int[] { 230, 863, 916, 585, 981, 404, 316, 785, 88, 12, 70, 435, 384, 778, 887, 755, 740, 337, 86, 92, 325, 422, 815, 650, 920, 125, 277, 336, 221, 847, 168, 23, 677, 61, 400, 136, 874, 363, 394, 199, 863, 997, 794, 587, 124, 321, 212, 957, 764, 173, 314, 422, 927, 783, 930, 282, 306, 506, 44, 926, 691, 568, 68, 730, 933, 737, 531, 180, 414, 751, 28, 546, 60, 371, 493, 370, 527, 387, 43, 541, 13, 457, 328, 227, 652, 365, 430, 803, 59, 858, 538, 427, 583, 368, 375, 173, 809, 896, 370, 789 }, 542);
        }

        [TestMethod]
        public void TestCase1()
        {
            var result = _solution.TwoSum(new int[] { 1, 5, 7}, 12);
            var answer = new int[] { 1, 2 };
            Assert.AreEqual(answer[0], result[0]);
            Assert.AreEqual(answer[1], result[1]);
        }

        [TestMethod]
        public void TestCase2()
        {
            var result = _solution.TwoSum(new int[] { 1, 5, -7, -12, 300}, -11);
            var answer = new int[] { 0, 3 };
            Assert.AreEqual(answer[0], result[0]);
            Assert.AreEqual(answer[1], result[1]);
        }

        [TestMethod]
        public void TestCase3()
        {
            var result = _solution.TwoSum(new int[] { 1, 11, -7, -12, 10000, 800, 4, -2 }, 2);
            var answer = new int[] { 6, 7 };
            Assert.AreEqual(answer[0], result[0]);
            Assert.AreEqual(answer[1], result[1]);
        }
    }
}