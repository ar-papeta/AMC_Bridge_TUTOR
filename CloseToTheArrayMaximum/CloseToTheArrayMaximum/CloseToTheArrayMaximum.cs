using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloseToTheArrayMaximum
{
    class CloseToTheArrayMaximum
    {
        static void Main(string[] args)
        {
            List<double> sequence_A = new List<double>();
            double eps;
            int count = 0;
            String s = Console.ReadLine();
            String[] input_A = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (String str in input_A)
            {
                sequence_A.Add(Convert.ToDouble(str));
            }
            eps = sequence_A[0];
            sequence_A.RemoveAt(0);
            double max = sequence_A[0];
            for (int i = 1; i < sequence_A.Count-1; i++)
            {
                if (max < sequence_A[i])
                    max = sequence_A[i]; 
            }
            for (int i = 0; i < sequence_A.Count-1; i++)
            {
                if ((Math.Abs(sequence_A[i] - max)) < eps)
                    count++;
            }
            Console.Write(count);
            //Console.ReadKey();
        }
    }
}
