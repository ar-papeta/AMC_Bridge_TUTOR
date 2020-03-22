using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DistanceBetweenTwo3DLines
{
    class DistanceBetweenTwo3DLines
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            List<Double> sequence_A = new List<Double>();
            String s = Console.ReadLine();
            String[] input_A = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (String str in input_A)
            {
                sequence_A.Add(Convert.ToDouble(str));
            }
            int j = 0;
            Vector r1 = new Vector(sequence_A[j++], sequence_A[j++], sequence_A[j++]);
            Vector s1 = new Vector(sequence_A[j++], sequence_A[j++], sequence_A[j++]);
            Vector r2 = new Vector(sequence_A[j++], sequence_A[j++], sequence_A[j++]);
            Vector s2 = new Vector(sequence_A[j++], sequence_A[j++], sequence_A[j++]);
            Vector r2r1 = new Vector(r2.x - r1.x, r2.y - r1.y, r2.z - r1.z);
            Vector S1xS2 = V1xV2(s1, s2);
            Double d12 = 0;
            if (s1.x/s2.x == s1.y/s2.y && s1.y / s2.y == s1.z / s2.z && Det(r2r1, s1, s2)==0)
                d12 = DetPar(r2r1, s1) / (Math.Sqrt(Math.Pow(s1.x, 2) + Math.Pow(s1.y, 2) + Math.Pow(s1.z, 2)));
            else if  (Det(r2r1, s1, s2) == 0)
                d12 = 0;
            else
                d12 = Det(r2r1, s1, s2) / (Math.Sqrt(Math.Pow(S1xS2.x, 2) + Math.Pow(S1xS2.y, 2) + Math.Pow(S1xS2.z, 2)));
            Console.Write(Math.Abs(d12));
            
        }
        static Double Det(Vector a, Vector b, Vector d)
        {
            return a.x * b.y * d.z + a.y * b.z * d.x + a.z * b.x * d.y - a.z * b.y * d.x - a.x * b.z * d.y - a.y * b.x * d.z;
        }
        static double DetPar(Vector a, Vector b)
        {
            Vector v = new Vector(a.y * b.z  - a.z * b.y, a.x * b.z  - a.z * b.x,  a.x * b.y  - a.y * b.x);
            return Math.Sqrt(Math.Pow(v.x, 2) + Math.Pow(v.y, 2) + Math.Pow(v.z, 2));
        }
        static Vector V1xV2(Vector a, Vector b)
        {
            return new Vector(a.y * b.z - a.z * b.y, a.x * b.z - a.z * b.x, a.x * b.y - a.y * b.x);
        }
    }
    

    class Vector
    {
        public Double x { get; set; }
        public Double y { get; set; }
        public Double z { get; set; }

        public Vector(Double x, Double y, Double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
