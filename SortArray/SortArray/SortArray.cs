using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    class SortArray
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            String[] input = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] nums = new int[Convert.ToInt32(input[0])];
            for(int i = 0; i < input.Length -1; i++)
            {
                nums[i] = Convert.ToInt32(input[i + 1]);
            }

            Array.Sort(nums);
            Console.Write(input[0]);
            foreach(int n in nums)
            {
                Console.Write(" " + n);
            }
            //Console.ReadKey();
        }
    }
}
