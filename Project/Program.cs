using System;

namespace Project
{
    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            int result = 0;

            foreach (int num in nums)
            {
                result ^= num;
            }

            return result;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();

            Console.WriteLine("Input :");
            string input = Console.ReadLine();

            string[] numStrings = input.Split(' ');
            int[] nums = new int[numStrings.Length];

            for (int i = 0; i < numStrings.Length; i++)
            {
                nums[i] = int.Parse(numStrings[i]);
            }

            int result = solution.SingleNumber(nums);
            
            Console.WriteLine("Output: " + result.ToString());

        }
    }
}