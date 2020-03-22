using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOrder
{
    class ReverseOrder
    {
        static void Main(string[] args)
        {
            List<int> sequence_A = new List<int>();
            List<int> sequence_B = new List<int>();
            String s = Console.ReadLine();
            String[] _sequences = s.Split(new String[] { "-1" }, StringSplitOptions.RemoveEmptyEntries);
            String[] input_A = _sequences[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input_A.Length; i++)
            {
                sequence_A.Add(Convert.ToInt32(input_A[i]));
            }
            /*
            for (int i = 0; i < input_A.Length/2; i++)
            {
                int temp;
                temp = sequence_A[i];
                sequence_A[i] = sequence_A[input_A.Length - i - 1];
                sequence_A[input_A.Length - i - 1] = temp;
            }
            
            foreach(int A in sequence_A)
            {
                Console.Write(A + " ");
            }
            */
            int[] b = new int[sequence_A.Count];
            b = sequence_A.ToArray();
            Array.Reverse(b);
            
            foreach(int A in b)
            {
                Console.Write(A + " ");
            }
            
            Console.Write("-1");
            //Console.ReadKey();
        }
    }
}
