using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DistanceBetweenPointAndLineIn3D
{
    class DistanceBetweenPointAndLineIn3D
    {
        static void Main(string[] args)
        {
            List<double> sequence_A = new List<double>();
            
            double LN = 0;
            double LV = 0;
            double VPX = 0;
            double VPY = 0;
            double VPZ = 0;
            double STORX = 0;
            double STORY = 0;
            double STORZ = 0;
            String s = Console.ReadLine();
            String[] input_A = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            foreach (String s1 in input_A)
            {
                sequence_A.Add(Convert.ToDouble(s1));
            }
            LN = Math.Sqrt(Math.Pow(sequence_A[6],2)+ Math.Pow(sequence_A[7], 2) + Math.Pow(sequence_A[8], 2));
            STORX = sequence_A[0] - sequence_A[3];
            STORY = sequence_A[1] - sequence_A[4];     //вектор между точкой и точкой на прямой
            STORZ = sequence_A[2] - sequence_A[5];
            VPX = sequence_A[7] * STORZ - sequence_A[8] * STORY;
            VPY = sequence_A[8] * STORX - sequence_A[6] * STORZ;
            VPZ = sequence_A[6] * STORY - sequence_A[7] * STORX;
            LV = Math.Sqrt(Math.Pow(VPX, 2) + Math.Pow(VPY, 2) + Math.Pow(VPZ, 2));
            double res = LV / LN;
            Console.Write(res);
            //Console.ReadLine();
        }
    }
}
