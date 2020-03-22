using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceAlteration
{
    class SequenceAlteration
    {
        static void Main(string[] args)
        {
            List<int> sequence_A = new List<int>();
            List<int> sequence_B = new List<int>();
            String s = Console.ReadLine();
            String[] _sequences = s.Split(new String[] { "-1" }, StringSplitOptions.RemoveEmptyEntries);
            String[] input_A = _sequences[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            String[] input_B = _sequences[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for(int i=0; i< input_A.Length; i++)
            {
                sequence_A.Add(Convert.ToInt32(input_A[i]));
            }
            for (int i = 0; i < input_B.Length; i++)
            {
                sequence_B.Add(Convert.ToInt32(input_B[i]));
            }
            for (int i = 0; i < input_B.Length; i++)
            {
                if(sequence_B[i] > 0)
                {
                    for(int j=0; j<sequence_B[i]; j++)
                        sequence_A.Add(sequence_B[i]);
                }
                else if (sequence_B[i] < 0 && sequence_A.Count < Math.Abs(sequence_B[i]))
                {
                    Console.Write("-1");
                    Console.ReadLine();
                    return;
                }
                else if (sequence_B[i] < 0)
                {
                    sequence_A.RemoveRange(sequence_A.Count - Math.Abs(sequence_B[i]), Math.Abs(sequence_B[i]));
                }
                else if (sequence_B[i] == 0)
                {
                    continue;
                }
            }
            
            int []output = sequence_A.ToArray();
                foreach (int elems in output)
                    Console.Write("{0} ", elems);
            Console.Write("-1");
            Console.ReadLine();
        }
    }
}
