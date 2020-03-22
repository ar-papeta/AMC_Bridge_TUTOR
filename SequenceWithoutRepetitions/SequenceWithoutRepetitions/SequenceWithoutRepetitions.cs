using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenceWithoutRepetitions
{
    class SequenceWithoutRepetitions
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
            sequence_A = sequence_A.Distinct().ToList();
            foreach(int data in sequence_A)
            {
                Console.Write(data + " ");
            }
            Console.Write(-1);
        }
    }
}
