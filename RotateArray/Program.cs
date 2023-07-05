using System;

namespace RotateArray
{
    public class Solution
    {
        public void RotateArr(int[] nums, int k)
        {
            var result = new int[nums.Length];
            k = k % nums.Length;
            for (var i = 0; i < nums.Length; i++)
            {
                var newIndex = (i + k) % nums.Length;
                result[newIndex] = nums[i];
            }

            for (var i = 0; i < nums.Length; i++)
            {
                nums[i] = result[i];
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите элементы массива через пробел:");
            var input = Console.ReadLine();

            var numbers = input.Split(' ');
            var nums = new int[numbers.Length];

            for (var i = 0; i < numbers.Length; i++)
            {
                nums[i] = int.Parse(numbers[i]);
            }

            Console.WriteLine("Введите количество шагов поворота:");
            var k = int.Parse(Console.ReadLine());

            var solution = new Solution();
            solution.RotateArr(nums, k);

            Console.WriteLine("Результат поворота массива:");
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}