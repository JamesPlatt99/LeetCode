using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode_Stuff;
using System.Linq;
using System.Text;

namespace Tests
{
    [TestClass]
    public class AddTwoNumbersTests
    {
        private AddTwoNumbersSolution _solution;

        [TestInitialize]
        public void Initialize()
        {
            _solution = new AddTwoNumbersSolution();
        }

        [TestMethod]
        public void TestGetList()
        {
            var list = AddTwoNumbersSolution.ListNode.GetList(new int[] { 0, 1, 2, 3 });
            Assert.AreEqual(list.val, 0);
            Assert.AreEqual(list.next.val, 1);
        }

        [TestMethod]
        public void TestListToString()
        {
            var list = AddTwoNumbersSolution.ListNode.GetList(new int[] { 0, 1, 2, 3 });
            Assert.AreEqual(list.ToString(), "0123");
        }

        [TestMethod]
        public void AddTwoNumbers()
        {
            var listA = AddTwoNumbersSolution.ListNode.GetList(new int[] { 1, 0, 0 });
            var listB = AddTwoNumbersSolution.ListNode.GetList(new int[] { 1, 0, 0 });

            var result = _solution.AddTwoNumbers(listA, listB);
            Assert.AreEqual(result.ToString(), "200");
        }

        [TestMethod]
        public void AddTwoNumbersOverflow()
        {

            var listA = AddTwoNumbersSolution.ListNode.GetList(new int[] { 9, 0, 0 });
            var listB = AddTwoNumbersSolution.ListNode.GetList(new int[] { 5, 0, 0 });

            var result = _solution.AddTwoNumbers(listA, listB);
            Assert.AreEqual(result.ToString(), "1400");
        }
    }
}
