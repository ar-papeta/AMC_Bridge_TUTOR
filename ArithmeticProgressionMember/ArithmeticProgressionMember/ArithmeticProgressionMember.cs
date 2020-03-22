using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticProgressionMember
{
    class ArithmeticProgressionMember
    {
        static void Main(string[] args)
        {
            List<int> sequence_A = new List<int>();
            String s = Console.ReadLine();
            String[] input_A = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int m=0;
            for (int i = 0; i < input_A.Length; i++)
            {
                sequence_A.Add(Convert.ToInt32(input_A[i]));
            }
            m = sequence_A[0] + sequence_A[1];
            for (int i=1; i < sequence_A[2]-1; i++)
            {
                m += sequence_A[1];
            }
            Console.Write(m);
            Console.ReadLine();
        }

    }
}
