using System;

namespace TwoSum
{
    public class TwoSum
    {
        /// <summary>
        /// Finds array of two indicies that addition of values equal to the target.
        /// </summary>
        /// <param name="nums">Array of integers</param>
        /// <param name="target">Target value to match</param>
        /// <returns>array of two indicies</returns>
        public int[] Solution1(int[] nums, int target)
        {
            int i, j = 0;
            bool flag = false;

            for (i = 0; i < nums.Length; i++)
            {
                for (j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        flag = true;
                        break;
                    }
                }

                if (flag)
                {
                    break;
                }
            }
            return new int[] { i, j };
        }
    }
}
