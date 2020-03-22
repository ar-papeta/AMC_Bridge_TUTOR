using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumOfThreeNumbers
{
    class MaximumOfThreeNumbers
    {
        static void Main(string[] args)
        {
            List<int> sequence_A = new List<int>();
            String s = Console.ReadLine();
            String[] input_A = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input_A.Length; i++)
            {
                sequence_A.Add(Convert.ToInt32(input_A[i]));
            }
            Console.Write(sequence_A[0] > sequence_A[1] ? (sequence_A[0] > sequence_A[2] ? sequence_A[0] : sequence_A[2]) : ((sequence_A[1] > sequence_A[2]) ? sequence_A[1] : sequence_A[2]));
        }
    }
}
