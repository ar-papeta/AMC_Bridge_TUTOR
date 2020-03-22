using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;

namespace DoesPointBelongTo2DTriangle
{
    class DoesPointBelongTo2DTriangle
    {
        static void Main(string[] args)
        {
            List<double> sequence_A = new List<double>();
            double PP1 = 0;
            double PP2 = 0;
            double PP3 = 0;
            String s = Console.ReadLine();
            String[] input_A = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            foreach (String s1 in input_A)
            {
                sequence_A.Add(Convert.ToDouble(s1));
            }
            PP1 = (sequence_A[2] - sequence_A[0]) * (sequence_A[5] - sequence_A[3]) - (sequence_A[4] - sequence_A[2]) * (sequence_A[3] - sequence_A[1]);
            PP2 = (sequence_A[4] - sequence_A[0]) * (sequence_A[7] - sequence_A[5]) - (sequence_A[6] - sequence_A[4]) * (sequence_A[5] - sequence_A[1]);
            PP3 = (sequence_A[6] - sequence_A[0]) * (sequence_A[3] - sequence_A[7]) - (sequence_A[2] - sequence_A[6]) * (sequence_A[7] - sequence_A[1]);
            if((PP1 >= 0 && PP2 >= 0 && PP3 >= 0) || (PP1 <= 0 && PP2 <= 0 && PP3 <= 0))
            {
                Console.Write(1);
            }
            else
                Console.Write(0);
            //Console.ReadKey();
        }
    }
}
