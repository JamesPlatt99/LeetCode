using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Stuff
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> solutions = new Dictionary<int, int>(nums.Count());
            for(int i = 0; i < nums.Count(); i++)
            {
                if(solutions.ContainsKey(nums[i]))
                {
                    return new int[] { solutions[nums[i]], i };
                }
                else
                {
                    int solution = target - nums[i];
                    solutions[solution] = i;
                }
            }
            return null;
        }            
    }
}
