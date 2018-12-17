using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Stuff
{
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            throw new NotImplementedException();
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }

            public static ListNode GetList(int[] values)
            {
                var output = new AddTwoNumbersSolution.ListNode(values[0]);
                var curNode = output;
                for (int i = 1; i < values.Count(); i++)
                {
                    curNode.next = new AddTwoNumbersSolution.ListNode(values[i]);
                    curNode = curNode.next;
                }
                return output;
            }

            public override string ToString()
            {
                ListNode list = this;
                var sb = new StringBuilder();
                while (list != null)
                {
                    sb.Append(list.val);
                    list = list.next;
                }
                return sb.ToString();
            }
        }
    }
}
