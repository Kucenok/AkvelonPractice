using System;
using System.Collections.Generic;
using System.Linq;

namespace Intersection
{
    public class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            var numCounts1 = CountElements(nums1);
            var numCounts2 = CountElements(nums2);

            var intersection = new List<int>();

            foreach (var kvp in numCounts1)
            {
                int num = kvp.Key;
                int count1 = kvp.Value;
                int count2;

                if (numCounts2.TryGetValue(num, out count2))
                {
                    int commonCount = Math.Min(count1, count2);
                    intersection.AddRange(Enumerable.Repeat(num, commonCount));
                }
            }

            return intersection.ToArray();
        }

        private Dictionary<int, int> CountElements(int[] nums)
        {
            var counts = new Dictionary<int, int>();

            foreach (int num in nums)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            }

            return counts;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();

            Console.WriteLine("Введите элементы первого массива через пробел:");
            string input1 = Console.ReadLine();
            int[] nums1 = ParseInput(input1);

            Console.WriteLine("Введите элементы второго массива через пробел:");
            string input2 = Console.ReadLine();
            int[] nums2 = ParseInput(input2);

            int[] intersection = solution.Intersection(nums1, nums2);

            Console.WriteLine("Пересечение массивов:");
            Console.WriteLine(string.Join(" ", intersection));
        }

        private static int[] ParseInput(string input)
        {
            string[] numStrings = input.Split(' ');
            int[] nums = new int[numStrings.Length];

            for (int i = 0; i < numStrings.Length; i++)
            {
                nums[i] = int.Parse(numStrings[i]);
            }

            return nums;
        }
    }
}
