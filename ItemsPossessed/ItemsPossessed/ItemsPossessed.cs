using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsPossessed
{
    class ItemsPossessed
    {
        static void Main(string[] args)
        {
            int f = 0;
            List<int> sequence_A = new List<int>();
            List<int> sequence_B = new List<int>();
            List<int> sequence_C = new List<int>();
            String s = Console.ReadLine();
            String[] _sequences = s.Split(new String[] { "-1" }, StringSplitOptions.RemoveEmptyEntries);
            String[] input_A = _sequences[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            String[] input_B = _sequences[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input_A.Length; i++)
            {
                sequence_A.Add(Convert.ToInt32(input_A[i]));
            }
            for (int i = 0; i < input_B.Length; i++)
            {
                sequence_B.Add(Convert.ToInt32(input_B[i]));
            }
            for (int i = 0; i < sequence_A.Count; i++)
            {
                for(int j = 0; j < sequence_B.Count; j++)
                {
                    if (sequence_A[i] == sequence_B[j])
                    {
                        sequence_C.Add(1);
                        f = 1;
                        break;
                    }
                }
                if(f == 0)
                    sequence_C.Add(0);
                f = 0;
            }
            foreach(int seq in sequence_C)
            {
                Console.Write(seq + " ");
            }
            Console.Write("-1");
            //Console.ReadKey();
        }
    }
}
