using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10
{
    public class Solution
    {
        public int BinarySearch(int[] nums, int target)
        {
            int i = 0, j = nums.Length - 1;
            while (i <= j)
            {
                int mid = i + (j - i) / 2;
                if (nums[mid] > target)
                {
                    j = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    i = mid + 1;
                }
                else
                {
                    j = mid - 1;
                }
            }
            return i;
        }

        public int FindRightBoundary(int[] nums, int target)
        {
            int i = BinarySearch(nums, target + 1);
            int j = i - 1;
            if (j < nums.Length && nums[j] == target)
            {
                return j;
            }
            return -1;
        }
    }
}
