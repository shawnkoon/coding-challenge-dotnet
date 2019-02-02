using System;
using Xunit;

namespace TwoSum.Tests
{
    public class UnitTest1
    {
        /// <summary>
        /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
        /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
        /// </summary>
        [Fact]
        public void Should_Work_As_We_Expect_it_to_1()
        {
            var twoSum = new TwoSum();
            var nums = new int[] { 2, 7, 11, 15 };
            var target = 9;

            Assert.Equal(twoSum.Solution1(nums, target), new int[] { 0, 1 });
        }
    }
}
