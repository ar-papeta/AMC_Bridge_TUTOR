using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricProgressionMember
{
    class GeometricProgressionMember
    {
        static void Main(string[] args)
        {
            List<double> sequence_A = new List<double>();
            String s = Console.ReadLine();
            String[] input_A = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double m = 0;
            for (int i = 0; i < input_A.Length; i++)
            {
                sequence_A.Add(Convert.ToDouble(input_A[i]));
            }
            m = sequence_A[0] * sequence_A[1];
            for (int i = 1; i < sequence_A[2] - 1; i++)
            {
                m *= sequence_A[1];
            }
            Console.Write(m);
            //Console.ReadLine();
        }
    }
}
