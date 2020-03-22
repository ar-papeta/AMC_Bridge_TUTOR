using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProgressionSum
{
    class GeometricProgressionSum
    {  /*
        static void Main(string[] args)
        {
            List<double> sequence_A = new List<double>();
            String s = Console.ReadLine();
            String[] input_A = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double m = 0;
            for (int i = 0; i < input_A.Length; i++)
            {
                sequence_A.Add(Convert.ToDouble(input_A[i]));
            }*/
       /*
       double sum;

       if (sequence_A[2] == 1)
       {
          sum = sequence_A[0];
       }
       else
       {
           m = sequence_A[0];
           sum = sequence_A[0];
           for (int i = 1; i < sequence_A[2]; i++)
           {
               m *= sequence_A[1];
               sum += m;
           }
       }
       Console.Write(sum);
       */
       /*
       Console.Write((sumOfGP(sequence_A[0], sequence_A[1], (int)sequence_A[2])));
       Console.ReadLine();
   }

   static double sumOfGP(double a, double r, int n)
   {
       double sum = 0;
       for (int i = 0; i < n; i++)
       {
           sum = sum + a;
           a = a * r;
       }
       return sum;
   }
   */
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] arr = line.Split();
            var first = arr.First().ToString();
            double[] a = Array.ConvertAll(arr, double.Parse).ToArray();

            double arithm = GeometricProgress(a[0], a[1], a[2]);

            Console.Write(String.Format("{0:0.00000000}", arithm + " "));
            Console.ReadKey();
        }

        static double GeometricProgress(double b1, double q, double n)
        {
            if (n == 1) return b1;
            return q * GeometricProgress(b1, q, n - 1);
        }
    }
}
