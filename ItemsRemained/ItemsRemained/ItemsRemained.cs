using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemsRemained
{
    class ItemsRemained
    {
        static void Main(string[] args)
        {
            List<int> sequence_A = new List<int>();
            List<int> sequence_B = new List<int>();
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
            for (int i = 0; i < sequence_B.Count; i++){
                for (int j = sequence_A.Count-1; j >= 0; j--)
                {
                    if (j % sequence_B[i] == 0)
                    {
                        sequence_A.RemoveAt(j);
                    } 
                }
            }
            foreach(int elems in sequence_A)
            {
                Console.Write(elems + " ");
            }
            Console.Write("-1");
            //Console.ReadKey();

        }

    }
}
