using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimumArrayMembers
{
    class MinimumArrayMembers
    {
        static void Main(string[] args)
        {
            List<int> sequence_A = new List<int>();
            String s = Console.ReadLine();
            String[] _sequences = s.Split(new String[] { "-1" }, StringSplitOptions.RemoveEmptyEntries);
            String[] input_A = _sequences[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input_A.Length; i++)
            {
                sequence_A.Add(Convert.ToInt32(input_A[i]));
            }
            int num = sequence_A[0];
            sequence_A.RemoveAt(0);
            sequence_A.Sort();
            sequence_A.Reverse();
            int c = 0;
            int sum = 0;
            foreach(int n in sequence_A)
            {

                if (sum < num)
                {
                    sum += n;
                    c++;
                }
                else if (sum >= num)
                {
                    Console.Write(c);
                    return;
                }   
            }
            Console.Write(-1);
        }
    }
}
