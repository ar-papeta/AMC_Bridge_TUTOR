using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Subsequence
{
    class Subsequence
    {
        static void Main(string[] args)
        {
            
            List<int> sequence_A = new List<int>();
            List<int> sequence_B = new List<int>();
            String s = Console.ReadLine();
            String[] _sequences = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 1; i <= Convert.ToInt32(_sequences[0]); i++)
            {
                sequence_A.Add(Convert.ToInt32(_sequences[i]));
            }
            for (int i = Convert.ToInt32(_sequences[0])+2; i < Convert.ToInt32(_sequences[0]) + 2 + Convert.ToInt32(_sequences[sequence_A.Count+1]); i++)
            {
                sequence_B.Add(Convert.ToInt32(_sequences[i]));
            }



            int j,k;
            for ( k = 0,j = 0; k < sequence_A.Count && j <sequence_B.Count; k++)
            {
                    if (sequence_A[k] == sequence_B[j])
                    {
                        j++;
                    }
                   
            }
            Console.Write((j == sequence_B.Count) ? 1 : 0);
            //Console.ReadLine();
            
        }
    }
}
