using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSubarray
{
    class LongestIncreasingSubarray
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            String[] input = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] nums = new int[Convert.ToInt32(input[0])];
            for (int i = 0; i < input.Length - 1; i++)
            {
                nums[i] = Convert.ToInt32(input[i + 1]);
            }
            int k = 1;
            int k_abs = 1;
            for(int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] < nums[i + 1])
                {
                    k++;
                }
                else
                {
                    k_abs = k>k_abs?k:k_abs;
                    k = 1;
                }
            }
            Console.Write(k_abs);
        }
    }
}
