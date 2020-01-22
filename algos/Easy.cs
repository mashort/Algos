using System;
using System.Collections.Generic;

namespace algos
{
    public class Easy
    {
        // Brute force version
        public int[] TwoSumBF(int[] nums, int target)
        {
            int[] returnVal = new int[2];
            
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        returnVal[0] = i;
                        returnVal[1] = j;
                        return returnVal;
                    }
                }
            }

            return returnVal;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] returnVal = new int[2];
            var d = new Dictionary<int, int>();
            
            for (int i = 0; i < nums.Length; i++)
            {
                int desiredValue = target - nums[i];

                if (d.ContainsKey(desiredValue))
                {
                    returnVal[0] = d[desiredValue];
                    returnVal[1] = i;
                    return returnVal;
                }

                if (!d.ContainsKey(nums[i]))
                {
                    d.Add(nums[i], i);
                }
            }

            return returnVal;
        }
    }
}