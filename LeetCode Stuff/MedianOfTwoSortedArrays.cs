using System.Linq;

namespace LeetCode_Stuff
{
    public class MedianOfTwoSortedArraysSolution 
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
        {
            int[] sortedArray = MergeArrays(nums1, nums2);
            return GetMedianFromArray(sortedArray);
        }

        private int[] MergeArrays(int[] nums1, int[] nums2)
        {
            int nums1Index = 0;
            int nums1Count = nums1.Count();
            int nums2Index = 0;
            int nums2Count = nums2.Count();
        
            int curIndex = 0;
            int[] output = new int[nums1Count + nums2Count];

            while(nums1Index < nums1Count || nums2Index < nums2Count)
            {
                if(nums2Index >= nums2Count || (nums1Index < nums1Count && nums1[nums1Index] < nums2[nums2Index]))
                {
                    output[curIndex] = nums1[nums1Index];
                    nums1Index++;
                }
                else
                {
                    output[curIndex] = nums2[nums2Index];
                    nums2Index++;
                }
                curIndex++;
            }
            return output;
        }

        private double GetMedianFromArray(int[] array)
        {
            if (array.Count() % 2 == 0)
            {
                int midpointA = array.Count() / 2 - 1;
                int midpointB = midpointA + 1;
                return (double)(array[midpointA] + array[midpointB]) / 2;
            }
            else
            {
                int midpoint = array.Count() / 2;
                return array[midpoint];
            }
        }
    }
}